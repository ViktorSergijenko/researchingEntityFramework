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
    public partial class AcessuaryForm : Form
    {
        // Defining and initializing new acessuary service
        private AcessuaryService AcessuaryService = new AcessuaryService();
        // Defining and initializing weapon type List
        static List<Acessuary> acessuaryList = new List<Acessuary>();
        public AcessuaryForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Method updates datagrid datasource
        /// </summary>
        private void UpdateDataGrid()
        {
            // Setting data source to null, in case if there already was something
            acessuaryDataGrid.DataSource = null;
            // Initializing data grid source with out list of objects
            acessuaryDataGrid.DataSource = acessuaryList;
        }

        /// <summary>
        /// Method will get data from DB and display it in datagrid
        /// </summary>
        private async void getDataButton_Click(object sender, EventArgs e)
        {
            // Setting data source to null, in case if there already was something
            acessuaryDataGrid.DataSource = null;
            // Initializing our list with data from DB by calling a method that get list of objects from DB
            acessuaryList = await AcessuaryService.GetList();
            // Initializing data grid source with out list of objects
            acessuaryDataGrid.DataSource = acessuaryList;
        }

        private async void addEditButton_Click(object sender, EventArgs e)
        {
            // If our hidden idTextBox is empty and dont have any value
            if (IdBox.Text == null || IdBox.Text.Equals(Guid.Empty) || IdBox.Text == "")
            {
                // We create new object
                Acessuary newAcessuary = new Acessuary();
                // Initializing object with values from text boxes
                newAcessuary.Name = nameBox.Text;
                newAcessuary.Price = Convert.ToDecimal(priceBox.Text);
                // Adding new object to DB by calling method that addes new object to DB and returnes it back(with id)
                var addedObject = await AcessuaryService.Save(newAcessuary);
                // Adding this new object to our list that is used to display objects in datagrid
                acessuaryList.Add(addedObject);
            }
            // In other case, if our id text box has some kind of value
            else
            {
                // Trying to parse string from id text box to Guid type
                var guidId = Guid.Parse(IdBox.Text);
                // Searching index of an object in our list, that has the same id
                var index = acessuaryList.FindIndex(x => x.Id == guidId);
                // Searching for that object in list that has the same guid id
                var objectToEdit = acessuaryList.FirstOrDefault(x => x.Id == guidId);
                // Initializing this object with values from text boxes
                objectToEdit.Name = nameBox.Text;
                objectToEdit.Price = Convert.ToDecimal(priceBox.Text);
                // Editing this object by calling method from service that edites objects in DB and returnes them back
                var editedObject = await AcessuaryService.Save(objectToEdit);
                // Updating object in our list that is used to display objects in data grid
                acessuaryList[index] = editedObject;
            }
            // Cleaning our text boxes values
            IdBox.Text = "";
            priceBox.Text = "";
            nameBox.Text = "";
            // Updating data grid source
            UpdateDataGrid();
        }
        /// <summary>
        /// Method deletes object from DB by clicking on Delete button
        /// </summary>
        private async void acessuaryDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // If row index is  equal to 0 and more
            if (e.RowIndex >= 0)
            {
                // And if user clicked on delete button
                if (e.ColumnIndex == Delete.Index)
                {
                    // Getting selected object from a row on that user has clicked
                    var objectFromRow = (Acessuary)acessuaryDataGrid.CurrentRow.DataBoundItem;
                    // Deleting selected object from Db by calling method from service
                    await AcessuaryService.Delete(objectFromRow.Id);
                    // Removing object from list
                    acessuaryList.Remove(objectFromRow);
                    // Udpating data grid source
                    UpdateDataGrid();
                }
            }
        }
        /// <summary>
        /// Method initialize our text boxes with values of an object that user has selected
        /// </summary>
        private void acessuaryDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Getting selected object from data grid
            var selectedObject = (Acessuary)acessuaryDataGrid.CurrentRow.DataBoundItem;
            // Initializing text boxes with values of an selected object
            IdBox.Text = selectedObject.Id.ToString();
            nameBox.Text = selectedObject.Name;
            priceBox.Text = Convert.ToString(selectedObject.Price);
        }

        private async void searchBox_TextChanged(object sender, EventArgs e)
        {
            acessuaryList = await AcessuaryService.FilterMethod(searchBox.Text);
            // Udpating data grid source
            UpdateDataGrid();
        }
    
    }
}
