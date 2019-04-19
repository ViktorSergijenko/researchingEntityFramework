using System.Collections.Generic;


namespace WindowsFormsApp1.Models
{
    /// <summary>
    /// Ammo shop model
    /// </summary>
    class AmmoShop : BaseEntity
    {
        /// <summary>
        /// AmmoShop constructor
        /// </summary>
        public AmmoShop() {
            // This is made to avoid problems with null reference
            Employees = new List<Employee>();
            Purchases = new List<Purchases>();
        }
        /// <summary>
        /// Ammo shop name
        /// </summary>
        public string ShopName { get; set; }
        /// <summary>
        /// Ammo shop address
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Ammo shop work time
        /// </summary>
        public string WorkTime { get; set; }
       /// <summary>
       /// List of employees that work in this ammo shop
       /// </summary>
       public List<Employee> Employees { get; set; }
       /// <summary>
       /// List of Purchases that was made in this ammo shop
       /// </summary>
       public List<Purchases> Purchases { get; set; }
    }
}
