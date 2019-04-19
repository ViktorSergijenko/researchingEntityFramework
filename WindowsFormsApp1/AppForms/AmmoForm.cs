using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Services;

namespace WindowsFormsApp1
{
    public partial class AmmoForm : Form
    {
        // Defining and initializing new ammo service
        private AmmoService AmmoService = new AmmoService();
        // Defining and initializing new Weapon type service
        private WeaponTypeService WeaponTypeService = new WeaponTypeService();
        // Defining and initializing ammo List
        static List<Ammo> ammoList = new List<Ammo>();
        public AmmoForm()
        {
            InitializeComponent();
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
                Ammo newAmmo = new Ammo();
                // Initializing object with values from text boxes
                newAmmo.Name = nameBox.Text;
                newAmmo.Price = Convert.ToDecimal(priceBox.Text);
                // Getting selected object from drop down(combo box)
                var selectedWeaponType = (WeaponType)weaponTypeComboBox.SelectedItem;
                // If selected item is not null
                if (selectedWeaponType != null)
                {
                    // Then we initializing object field with an value from selected object
                    newAmmo.WeaponTypeId = selectedWeaponType.Id;
                }
                // Adding new object to DB by calling method that addes new object to DB and returnes it back(with id)
                var addedObject = await AmmoService.Save(newAmmo);
                // Adding this new object to our list that is used to display objects in datagrid
                ammoList.Add(addedObject);
            }
            // In other case, if our id text box has some kind of value
            else
            {
                // Trying to parse string from id text box to Guid type
                var guidId = Guid.Parse(IdBox.Text);
                // Searching index of an object in our list, that has the same id
                var index = ammoList.FindIndex(x => x.Id == guidId);
                // Searching for that object in list that has the same guid id
                var objectToEdit = ammoList.FirstOrDefault(x => x.Id == guidId);
                // Initializing this object with values from text boxes
                objectToEdit.Name = nameBox.Text;
                objectToEdit.Price = Convert.ToDecimal(priceBox.Text);
                // Getting selected item from a drop down(combo box)
                var selectedItemInDropDown = (WeaponType)weaponTypeComboBox.SelectedItem;
                // Initializing object field that we want to edit with an value from selected object from drop down
                objectToEdit.WeaponTypeId = selectedItemInDropDown.Id;
                // Editing this object by calling method from service that edites objects in DB and returnes them back
                var editedObject = await AmmoService.Save(objectToEdit);
                // Updating object in our list that is used to display objects in data grid
                ammoList[index] = editedObject;
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
            ammoDataGrid.DataSource = null;
            // Initializing data grid source with out list of objects
            ammoDataGrid.DataSource = ammoList;
        }
        /// <summary>
        /// Method will get data from DB and display it in datagrid
        /// </summary>
        private async void getDataButton_Click(object sender, EventArgs e)
        {
            // Setting data source to null, in case if there already was something
            ammoDataGrid.DataSource = null;
            // Initializing our list with data from DB by calling a method that get list of objects from DB
            ammoList = await AmmoService.GetList();
            // Initializing data grid source with out list of objects
            ammoDataGrid.DataSource = ammoList;
            // Initializing drop down source with objects from DB
            weaponTypeComboBox.DataSource = await WeaponTypeService.GetList();
            // Setting what fields can be displayed in drop down
            weaponTypeComboBox.DisplayMember = "Name";
            weaponTypeComboBox.ValueMember = "Name";
        }
        /// <summary>
        /// Method deletes object from DB by clicking on Delete button
        /// </summary>
        private async void ammoDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // If row index is  equal to 0 and more
            if (e.RowIndex >= 0)
            {
                // And if user clicked on delete button
                if (e.ColumnIndex == Delete.Index)
                {
                    // Getting selected object from a row on that user has clicked
                    var objectFromRow = (Ammo)ammoDataGrid.CurrentRow.DataBoundItem;
                    // Deleting selected object from Db by calling method from service
                    await AmmoService.Delete(objectFromRow.Id);
                    // Removing object from list
                    ammoList.Remove(objectFromRow);
                    // Udpating data grid source
                    UpdateDataGrid();
                }
            }
        }
        /// <summary>
        /// Method initialize our text boxes and drop down with values of an object that user has selected
        /// </summary>
        private void ammoDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Getting selected object from data grid
            var selectedObject = (Ammo)ammoDataGrid.CurrentRow.DataBoundItem;
            // Initializing text boxes with values of an selected object
            IdBox.Text = selectedObject.Id.ToString();
            nameBox.Text = selectedObject.Name;
            priceBox.Text = Convert.ToString(selectedObject.Price);
            // Searching for index of an object in drop down source with a specific string value
            var index = weaponTypeComboBox.FindString(selectedObject.WeaponTypes.Name);
            // Setting dropdown value
            weaponTypeComboBox.SelectedItem = weaponTypeComboBox.Items[index];
        }

        private async void searchBox_TextChanged(object sender, EventArgs e)
        {
            ammoList = await AmmoService.FilterMethod(searchBox.Text);
            // Udpating data grid source
            UpdateDataGrid();
        }
    }
    
}
