using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Services;

namespace WindowsFormsApp1
{

    public partial class WeaponForm : Form
    {
        // Defining and initializing new weapon service
        private WeaponService WeaponService = new WeaponService();
        // Defining and initializing new Weapon type service
        private WeaponTypeService WeaponTypeService = new WeaponTypeService();
        // Defining and initializing weapon  List
        static List<Weapon> weaponList = new List<Weapon>();
        public WeaponForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Method will get data from DB and display it in datagrid
        /// </summary>
        private async void getDataButton_Click(object sender, EventArgs e)
        {
            // Setting data source to null, in case if there already was something
            weaponDataGrid.DataSource = null;
            // Initializing our list with data from DB by calling a method that get list of objects from DB
            weaponList = await WeaponService.GetAllWeaponsList();
            // Initializing data grid source with out list of objects
            weaponDataGrid.DataSource = weaponList;
            // Initializing drop down source with objects from DB
            weaponTypeComboBox.DataSource = await WeaponTypeService.GetList();
            // Setting what fields can be displayed in drop down
            weaponTypeComboBox.DisplayMember = "Name";
            weaponTypeComboBox.ValueMember = "Name";
        }

        /// <summary>
        /// Method edits or adds an object in/to database
        /// </summary>
        private async void addEditButton_Click(object sender, EventArgs e)
        {
            // If our hidden idTextBox is empty and dont have any value
            if (IdBox.Text == null || IdBox.Text.Equals(Guid.Empty) || IdBox.Text == "")
            {
                // We create new object
                Weapon newWeapon = new Weapon();
                // Initializing object with values from text boxes
                newWeapon.Name = nameBox.Text;
                newWeapon.Price = Convert.ToDecimal(priceBox.Text);
                // Getting selected object from drop down(combo box)
                var selectedWeaponType = (WeaponType)weaponTypeComboBox.SelectedItem;
                // If selected item is not null
                if (selectedWeaponType!=null)
                {
                    // Then we initializing object field with an value from selected object
                    newWeapon.WeaponTypeId = selectedWeaponType.Id;
                }
                // Adding new object to DB by calling method that addes new object to DB and returnes it back(with id)
                var addedObject = await WeaponService.Save(newWeapon);
                // Adding this new object to our list that is used to display objects in datagrid
                weaponList.Add(addedObject);
            }
            // In other case, if our id text box has some kind of value
            else
            {
                // Trying to parse string from id text box to Guid type
                var guidId = Guid.Parse(IdBox.Text);
                // Searching index of an object in our list, that has the same id
                var index = weaponList.FindIndex(x => x.Id == guidId);
                // Searching for that object in list that has the same guid id
                var objectToEdit = weaponList.FirstOrDefault(x => x.Id == guidId);
                // Initializing this object with values from text boxes
                objectToEdit.Name = nameBox.Text;
                objectToEdit.Price = Convert.ToDecimal(priceBox.Text);
                // Getting selected item from a drop down(combo box)
                var selectedItemInDropDown = (WeaponType)weaponTypeComboBox.SelectedItem;
                // Initializing object field that we want to edit with an value from selected object from drop down
                objectToEdit.WeaponTypeId = selectedItemInDropDown.Id;
                // Editing this object by calling method from service that edites objects in DB and returnes them back
                var editedObject = await WeaponService.Save(objectToEdit);
                // Updating object in our list that is used to display objects in data grid
                weaponList[index] = editedObject;
            }
            // Cleaning our text boxes values
            IdBox.Text = "";
            priceBox.Text = "";
            nameBox.Text = "";
            // Updating data grid source
            UpdateDataGrid();


        }
        /// <summary>
        /// Method updates datagrid datasource
        /// </summary>
        private void UpdateDataGrid()
        {
            // Setting data source to null, in case if there already was something
            weaponDataGrid.DataSource = null;
            // Initializing data grid source with out list of objects
            weaponDataGrid.DataSource = weaponList;
        }

        /// <summary>
        /// Method initialize our text boxes and drop down with values of an object that user has selected
        /// </summary>
        private void weaponDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Getting selected object from data grid
            var selectedObject = (Weapon)weaponDataGrid.CurrentRow.DataBoundItem;
            // Initializing text boxes with values of an selected object
            IdBox.Text = selectedObject.Id.ToString();
            nameBox.Text = selectedObject.Name;
            priceBox.Text = Convert.ToString(selectedObject.Price);
            // Searching for index of an object in drop down source with a specific string value
            var index = weaponTypeComboBox.FindString(selectedObject.WeaponType.Name);
            // Setting dropdown value
            weaponTypeComboBox.SelectedItem = weaponTypeComboBox.Items[index];
        }
        /// <summary>
        /// Method deletes object from DB by clicking on Delete button
        /// </summary>
        private async void weaponDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // If row index is  equal to 0 and more
            if (e.RowIndex >= 0)
            {
                // And if user clicked on delete button
                if (e.ColumnIndex == Delete.Index)
                {
                    // Getting selected object from a row on that user has clicked
                    var objectFromRow = (Weapon)weaponDataGrid.CurrentRow.DataBoundItem;
                    // Deleting selected object from Db by calling method from service
                    await WeaponService.Delete(objectFromRow.Id);
                    // Removing object from list
                    weaponList.Remove(objectFromRow);
                    // Udpating data grid source
                    UpdateDataGrid();
                }
            }
        }

        private async void searchBox_TextChanged(object sender, EventArgs e)
        {
            weaponList = await WeaponService.FilterMethod(searchBox.Text);
            // Udpating data grid source
            UpdateDataGrid();
        }
    }
}
