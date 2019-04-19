using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.AppContext;
using WindowsFormsApp1.Services;
using Microsoft.Extensions.DependencyInjection;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{

    public partial class AmmoShopForm : Form
    {
        // Defining and initializing ammo shop service
        private AmmoShopService AmmoShopService = new AmmoShopService();
        // Defining and initializing AmmoShop List
        static List<AmmoShop> ammoShopList = new List<AmmoShop>();
        public AmmoShopForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Method will get data from DB and display it in datagrid
        /// </summary>
        private async void getDataButton_Click(object sender, EventArgs e)
        {
            // Setting data source to null, in case if there already was something
            ammoShopDataGrid.DataSource = null;
            // Initializing our list with data from DB by calling a method that get list of objects from DB
            ammoShopList = await AmmoShopService.GetList();
            // Initializing data grid source with out list of objects
            ammoShopDataGrid.DataSource = ammoShopList;
        }
        /// <summary>
        /// Method edits or adds an object in/to database
        /// </summary>
        private async void addAmmoShop_Click(object sender, EventArgs e)
        {
            // If our hidden idTextBox is empty and dont have any value
            if (ammoId.Text == null || ammoId.Text.Equals(Guid.Empty) || ammoId.Text == "")
            {
                // We create new object
                AmmoShop newAmmoShop = new AmmoShop();
                // Initializing object with values from text boxes
                newAmmoShop.Address = addressBox.Text;
                newAmmoShop.ShopName = ammoNameBox.Text;
                newAmmoShop.WorkTime = workTimeBox.Text;
                // Adding new object to DB by calling method that addes new object to DB and returnes it back(with id)
                var addedObject = await AmmoShopService.Save(newAmmoShop);
                // Adding this new object to our list that is used to display objects in datagrid
                ammoShopList.Add(newAmmoShop);
            }
            // In other case, if our id text box has some kind of value
            else
            {
                // Trying to parse string from id text box to Guid type
                var guidId = Guid.Parse(ammoId.Text);
                // Searching index of an object in our list, that has the same id
                var index = ammoShopList.FindIndex(x => x.Id == guidId);
                // Searching for that object in list that has the same guid id
                var objectToEdit = ammoShopList.FirstOrDefault(x => x.Id == guidId);
                // Initializing this object with values from text boxes
                objectToEdit.ShopName = ammoNameBox.Text;
                objectToEdit.Address = addressBox.Text;
                objectToEdit.WorkTime = workTimeBox.Text;
                // Editing this object by calling method from service that edites objects in DB and returnes them back
                var editedObject = await AmmoShopService.Save(objectToEdit);
                // Updating object in our list that is used to display objects in data grid
                ammoShopList[index] = editedObject;
            }
            // Cleaning our text boxes values
            ammoId.Text = "";
            ammoNameBox.Text = "";
            addressBox.Text = "";
            workTimeBox.Text = "";
            // Updating data grid source
            UpdateDataGrid();


        }
        /// <summary>
        /// Method initialize our text boxes with values of an object that user has selected
        /// </summary>
        private void ammoShopDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Getting selected object from data grid
            var selectedObject = (AmmoShop)ammoShopDataGrid.CurrentRow.DataBoundItem;
            // Initializing text boxes with values of an selected object
            ammoId.Text = selectedObject.Id.ToString();
            workTimeBox.Text = selectedObject.WorkTime;
            ammoNameBox.Text = selectedObject.ShopName;
            addressBox.Text = selectedObject.Address;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Method updates datagrid datasource
        /// </summary>
        private void UpdateDataGrid() {
            ammoShopDataGrid.DataSource = null;
            ammoShopDataGrid.DataSource = ammoShopList;
        }
        /// <summary>
        /// Method deletes object from DB by clicking on Delete button
        /// </summary>
        private async void ammoShopDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // If row index is  equal to 0 and more
            if (e.RowIndex >=0)
            {
                // And if user clicked on delete button
                if (e.ColumnIndex == Delete.Index)
                {
                    // Getting selected object from a row on that user has clicked
                    var objectFromRow = (AmmoShop)ammoShopDataGrid.CurrentRow.DataBoundItem;
                    // Deleting selected object from Db by calling method from service
                    await AmmoShopService.Delete(objectFromRow.Id);
                    // Removing object from list
                    ammoShopList.Remove(objectFromRow);
                    // Udpating data grid source
                    UpdateDataGrid();
                }
            }
        }

        private async void searchBox_TextChanged(object sender, EventArgs e)
        {
            ammoShopList = await AmmoShopService.FilterMethod(searchBox.Text);
            // Udpating data grid source
            UpdateDataGrid();
        }
    }
}
