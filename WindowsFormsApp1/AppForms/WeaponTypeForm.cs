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
    public partial class WeaponTypeForm : Form
    {
        // Defining and initializing new Weapon type service
        private WeaponTypeService WeaponTypeService = new WeaponTypeService();
        // Defining and initializing weapon type List
        static List<WeaponType> weaponTypeList = new List<WeaponType>();
        public WeaponTypeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method will get data from DB and display it in datagrid
        /// </summary>
        private async void getDataButton_Click(object sender, EventArgs e)
        {
            // Setting data source to null, in case if there already was something
            weaponTypeDataGrid.DataSource = null;
            // Initializing our list with data from DB by calling a method that get list of objects from DB
            weaponTypeList = await WeaponTypeService.GetList();
            // Initializing data grid source with out list of objects
            weaponTypeDataGrid.DataSource = weaponTypeList;
        }
        /// <summary>
        /// Method updates datagrid datasource
        /// </summary>
        private void UpdateDataGrid()
        {
            // Setting data source to null, in case if there already was something
            weaponTypeDataGrid.DataSource = null;
            // Initializing data grid source with out list of objects
            weaponTypeDataGrid.DataSource = weaponTypeList;
        }

        /// <summary>
        /// Method edits or adds an object in/to database
        /// </summary>
        private async void addEditWeaponTypeButton_Click(object sender, EventArgs e)
        {
            // If our hidden idTextBox is empty and dont have any value
            if (weaponTypeIdBox.Text == null || weaponTypeIdBox.Text.Equals(Guid.Empty) || weaponTypeIdBox.Text == "")
            {
                // We create new object
                WeaponType newWeaponType = new WeaponType();
                // Initializing object with values from text boxes
                newWeaponType.Name = weaponTypeNameBox.Text;
                // Adding new object to DB by calling method that addes new object to DB and returnes it back(with id)
                var addedObject = await WeaponTypeService.Save(newWeaponType);
                // Adding this new object to our list that is used to display objects in datagrid
                weaponTypeList.Add(addedObject);
            }
            // In other case, if our id text box has some kind of value
            else
            {
                // Trying to parse string from id text box to Guid type
                var guidId = Guid.Parse(weaponTypeIdBox.Text);
                // Searching index of an object in our list, that has the same id
                var index = weaponTypeList.FindIndex(x => x.Id == guidId);
                // Searching for that object in list that has the same guid id
                var objectToEdit = weaponTypeList.FirstOrDefault(x => x.Id == guidId);
                // Initializing this object with values from text boxes
                objectToEdit.Name = weaponTypeNameBox.Text;
                // Editing this object by calling method from service that edites objects in DB and returnes them back
                var editedObject = await WeaponTypeService.Save(objectToEdit);
                // Updating object in our list that is used to display objects in data grid
                weaponTypeList[index] = editedObject;
            }
            // Cleaning our text boxes values
            weaponTypeIdBox.Text = "";
            weaponTypeNameBox.Text = "";
            // Updating data grid source
            UpdateDataGrid();
        }

        /// <summary>
        /// Method deletes object from DB by clicking on Delete button
        /// </summary>
        private async void weaponTypeDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // If row index is  equal to 0 and more
            if (e.RowIndex >= 0)
            {
                // And if user clicked on delete button
                if (e.ColumnIndex == Delete.Index)
                {
                    // Getting selected object from a row on that user has clicked
                    var objectFromRow = (WeaponType)weaponTypeDataGrid.CurrentRow.DataBoundItem;
                    // Deleting selected object from Db by calling method from service
                    await WeaponTypeService.Delete(objectFromRow.Id);
                    // Removing object from list
                    weaponTypeList.Remove(objectFromRow);
                    // Udpating data grid source
                    UpdateDataGrid();
                }
            }
        }
        /// <summary>
        /// Method initialize our text boxes with values of an object that user has selected
        /// </summary>
        private void weaponTypeDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Getting selected object from data grid
            var selectedObject = (WeaponType)weaponTypeDataGrid.CurrentRow.DataBoundItem;
            // Initializing text boxes with values of an selected object
            weaponTypeIdBox.Text = selectedObject.Id.ToString();
            weaponTypeNameBox.Text = selectedObject.Name;

        }

        private async void searchBox_TextChanged(object sender, EventArgs e)
        {
            weaponTypeList = await WeaponTypeService.FilterMethod(searchBox.Text);
            // Udpating data grid source
            UpdateDataGrid();
        }
    }
}
