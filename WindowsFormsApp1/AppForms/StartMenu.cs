using Microsoft.EntityFrameworkCore;
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
using WindowsFormsApp1.AppForms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        private  void button1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Method opens ammo shop form
        /// </summary>
        private void ammoShopListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Initializing form
            AmmoShopForm shopForm = new AmmoShopForm();
            // Opening form
            shopForm.ShowDialog(this);
            shopForm.Dispose();
        }
        /// <summary>
        /// Method opens weapon type form
        /// </summary>
        private void weaponTypeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Initializing form
            WeaponTypeForm weaponTypeForm = new WeaponTypeForm();
            // Opening form
            weaponTypeForm.ShowDialog(this);
            // Disposing form
            weaponTypeForm.Dispose();
        }
        /// <summary>
        /// Method opens weapon form
        /// </summary>
        private void weaponListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Initializing form
            WeaponForm weaponForm = new WeaponForm();
            // Opening form
            weaponForm.ShowDialog(this);
            // Disposing form
            weaponForm.Dispose();
        }
        /// <summary>
        /// Method opens ammo form
        /// </summary>
        private void ammoListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Initializing form
            AmmoForm weaponForm = new AmmoForm();
            // Opening form
            weaponForm.ShowDialog(this);
            // Disposing form
            weaponForm.Dispose();
        }
        /// <summary>
        /// Method opens acessuary  form
        /// </summary>
        private void acessuaryListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Initializing form
            AcessuaryForm weaponForm = new AcessuaryForm();
            // Opening form
            weaponForm.ShowDialog(this);
            // Disposing form
            weaponForm.Dispose();
        }
        /// <summary>
        /// Method opens employee form
        /// </summary>
        private void employeeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Initializing form
            EmployeeForm employeeForm = new EmployeeForm();
            // Opening form
            employeeForm.ShowDialog(this);
            // Disposing form
            employeeForm.Dispose();
        }
        /// <summary>
        /// Method opens purchases form
        /// </summary>
        private void purchasesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Initializing form
            PurchasesForm employeeForm = new PurchasesForm();
            // Opening form
            employeeForm.ShowDialog(this);
            // Disposing form
            employeeForm.Dispose();
        }
    }
}
