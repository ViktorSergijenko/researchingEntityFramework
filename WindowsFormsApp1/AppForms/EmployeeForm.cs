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
    public partial class EmployeeForm : Form
    {
        // Initializing new EmployeeService 
        private EmployeeService EmployeeService = new EmployeeService();
        // Initializing new AmmoShopService 
        private AmmoShopService AmmoShopService = new AmmoShopService();
        // Defining and initializing employee List
        static List<Employee> employeeList = new List<Employee>();
        public EmployeeForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Method will get data from DB and display it in datagrid
        /// </summary>
        private async void getDataButton_Click(object sender, EventArgs e)
        {
            // Setting data source to null, in case if there already was something
            employeeDataGrid.DataSource = null;
            // Initializing our list with data from DB by calling a method that get list of objects from DB
            employeeList = await EmployeeService.GetList();
            // Initializing data grid source with out list of objects
            employeeDataGrid.DataSource = employeeList;
            // Initializing drop downs source with objects from DB
            ammoShopComboBox.DataSource = await AmmoShopService.GetList();
            reportsToComboBox.DataSource = employeeList;
            // Setting what fields can be displayed in drop down
            ammoShopComboBox.DisplayMember = "ShopName";
            ammoShopComboBox.ValueMember = "ShopName";
            reportsToComboBox.DisplayMember = "FullName";
            reportsToComboBox.ValueMember = "FullName";
            // Clearing tree view from nodes
            employeeTreeView.Nodes.Clear();
            // Clearing our nodes
            TreeNode root = null;
            // Creating nodes
            PopulateTree(employeeList, ref root);
            // Adding created nodes to tree view
            employeeTreeView.Nodes.Add(root);

        }
        /// <summary>
        /// Method deletes object from DB by clicking on Delete button
        /// </summary>
        private async void employeeDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // If row index is  equal to 0 and more
            if (e.RowIndex >= 0)
            {
                // And if user clicked on delete button
                if (e.ColumnIndex == Delete.Index)
                {
                    // Getting selected object from a row on that user has clicked
                    var objectFromRow = (Employee)employeeDataGrid.CurrentRow.DataBoundItem;
                    // Deleting selected object from Db by calling method from service
                    await EmployeeService.Delete(objectFromRow.Id);
                    // Removing object from list
                    employeeList.Remove(objectFromRow);
                    // Udpating data grid source
                    UpdateDataGrid();
                }
            }
        }

        /// <summary>
        /// Method initialize our text boxes and drop down with values of an object that user has selected
        /// </summary>
        private void employeeDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Getting selected object from data grid
            var selectedObject = (Employee)employeeDataGrid.CurrentRow.DataBoundItem;
            // Initializing text boxes with values of an selected object
            IdBox.Text = selectedObject.Id.ToString();
            fullNameBox.Text = selectedObject.FullName;
            personalCodeBox.Text = selectedObject.PersCode;
            // Searching for index of an object in drop down source with a specific string value
            var indexShop = ammoShopComboBox.FindString(selectedObject.AmmoShop.ShopName);
            var indexBoss = reportsToComboBox.FindString(selectedObject.Boss.FullName);
            // Setting dropdown value
            ammoShopComboBox.SelectedItem = ammoShopComboBox.Items[indexShop];
            ammoShopComboBox.SelectedItem = reportsToComboBox.Items[indexBoss];
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
                Employee newEmployee = new Employee();
                // Initializing object with values from text boxes
                newEmployee.FullName = fullNameBox.Text;
                newEmployee.PersCode = personalCodeBox.Text;
                // Getting selected object from drop down(combo box)
                var selectedAmmoShop = (AmmoShop)ammoShopComboBox.SelectedItem;
                // If selected item is not null
                if (selectedAmmoShop != null)
                {
                    // Then we initializing object field with an value from selected object
                    newEmployee.AmmoShopId = selectedAmmoShop.Id;
                }
                var selectedBoss = (Employee)reportsToComboBox.SelectedItem;
                // If selected item is not null
                if (selectedBoss != null)
                {
                    // Then we initializing object field with an value from selected object
                    newEmployee.ReportsTo = selectedBoss.Id;
                }
                // Adding new object to DB by calling method that addes new object to DB and returnes it back(with id)
                var addedObject = await EmployeeService.Save(newEmployee);
                // Adding this new object to our list that is used to display objects in datagrid
                employeeList.Add(addedObject);
            }
            else
            {
                // Trying to parse string from id text box to Guid type
                var guidId = Guid.Parse(IdBox.Text);
                // Searching index of an object in our list, that has the same id
                var index = employeeList.FindIndex(x => x.Id == guidId);
                // Searching for that object in list that has the same guid id
                var objectToEdit = employeeList.FirstOrDefault(x => x.Id == guidId);
                // Initializing this object with values from text boxes
                objectToEdit.FullName = fullNameBox.Text;
                objectToEdit.PersCode = personalCodeBox.Text;
                // Getting selected item from a drop down(combo box)
                var selectedAmmoShop = (AmmoShop)ammoShopComboBox.SelectedItem;
                // Initializing object field that we want to edit with an value from selected object from drop down
                objectToEdit.AmmoShopId = selectedAmmoShop.Id;
                // Getting selected item from a drop down(combo box)
                var selectedBoss = (Employee)reportsToComboBox.SelectedItem;
                // Initializing object field that we want to edit with an value from selected object from drop down
                objectToEdit.ReportsTo = selectedBoss.Id;
                // Editing this object by calling method from service that edites objects in DB and returnes them back
                var editedObject = await EmployeeService.Save(objectToEdit);
                // Updating object in our list that is used to display objects in data grid
                employeeList[index] = editedObject;
            }
            // Cleaning our text boxes values
            IdBox.Text = "";
            fullNameBox.Text = "";
            personalCodeBox.Text = "";
            // Updating data grid source
            UpdateDataGrid();
        }
        /// <summary>
        /// Method updates datagrid datasource
        /// </summary>
        private void UpdateDataGrid()
        {
            // Setting data source to null, in case if there already was something
            employeeDataGrid.DataSource = null;
            // Initializing data grid source with out list of objects
            employeeDataGrid.DataSource = employeeList;
        }

        private async void searchBox_TextChanged(object sender, EventArgs e)
        {
            employeeList = await EmployeeService.FilterMethod(searchBox.Text);
            // Udpating data grid source
            UpdateDataGrid();
        }

        private void PopulateTree(List<Employee> employee, ref TreeNode root)
        {
            if (root == null)
            {
                root = new TreeNode();
                root.Text = "Employee list";
                root.Tag = null;
                // get all employees in the list where Boss is null
                var details = employee.Where(x => x.Boss == null);
                foreach (var detail in details)
                {
                    var child = new TreeNode()
                    {
                        Text = detail.FullName,
                        Tag = detail.Id,
                    };
                    PopulateTree(employee, ref child);
                    root.Nodes.Add(child);
                }
            }
            else
            {
                var id = (Guid)root.Tag;
                var details = employee.Where(x => x.ReportsTo == id);
                foreach (var detail in details)
                {
                    var child = new TreeNode()
                    {
                        Text = detail.FullName,
                        Tag = detail.Id,
                    };
                    PopulateTree(employee, ref child);
                    root.Nodes.Add(child);
                }
            }
        }
    }
    
}
