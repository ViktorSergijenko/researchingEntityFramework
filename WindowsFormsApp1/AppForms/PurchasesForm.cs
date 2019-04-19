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

namespace WindowsFormsApp1.AppForms
{

    public partial class PurchasesForm : Form
    {
        // Defining and initializing new weapon service
        private AmmoShopService AmmoShopService = new AmmoShopService();
        // Defining and initializing new weapon service
        private WeaponService WeaponService = new WeaponService();
        // Defining and initializing new AcessuaryService
        private AcessuaryService AcessuaryService = new AcessuaryService();
        // Defining and initializing new Ammo service
        private AmmoService AmmoService = new AmmoService();
        // Defining and initializing new EmployeeService
        private EmployeeService EmployeeService = new EmployeeService();
        // Defining and initializing new CustomerService
        private CustomerService CustomerService = new CustomerService();
        // Defining and initializing new PurchasesService
        private PurchasesService PurchasesService = new PurchasesService();
        // Defining and initializing weapon  List
        static List<Purchases> purchasesList = new List<Purchases>();
        // Defining and initializing weapon list
        static List<Weapon> weaponList = new List<Weapon>();
        // Defining and initializing employee list
        static List<Employee> employeeList = new List<Employee>();
        // Defining and initializing ammo shop list
        static List<AmmoShop> ammoShopList = new List<AmmoShop>();
        // Defining and initializing ammo list
        static List<Ammo> ammoList = new List<Ammo>();
        // Defining and initializing ammo list
        static List<Acessuary> acessuacryList = new List<Acessuary>();
        public PurchasesForm()
        {
            InitializeComponent();
         
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(ammoShopList);
        }

        private async void PurchasesForm_Load(object sender, EventArgs e)
        {
            // Getting all needed information from DB
            weaponList = await WeaponService.GetAllWeaponsList();
            ammoList = await AmmoService.GetList();
            acessuacryList = await AcessuaryService.GetList();
            ammoShopList = await AmmoShopService.GetList();
            purchasesList = await PurchasesService.GetAllWeaponsList();
            employeeList = await EmployeeService.GetList();



            weaponComboBox.DataSource = weaponList;
            weaponComboBox.DisplayMember = "Name";
            weaponComboBox.ValueMember = "Name";


        }
    }
}
