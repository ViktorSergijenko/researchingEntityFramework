using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    /// <summary>
    /// Employee model
    /// </summary>
    class Employee : BaseEntity
    {
        /// <summary>
        /// Employee class constructor
        /// </summary>
        public Employee()
        {
            // This is made to avoid problems related with null reference
            Employees = new List<Employee>();
            Purchases = new List<Purchases>();
        }
        /// <summary>
        /// Employee full name
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Employee personal code
        /// </summary>
        public string PersCode { get; set; }
        /// <summary>
        /// Id of an boss that this employee is attached to
        /// </summary>
        [System.ComponentModel.Browsable(false)] // This is an attribute, that disables visability of this field in data grid view
        public Guid? ReportsTo { get; set; }
        /// <summary>
        /// Boss to that this employee is attached to
        /// </summary>
        [System.ComponentModel.Browsable(false)] // This is an attribute, that disables visability of this field in data grid view
        public Employee Boss { get; set; }
        /// <summary>
        /// List of employees to that this employee is marked as a boss
        /// </summary>
        public List<Employee> Employees { get; set; }
        /// <summary>
        /// Id of an ammo hsop where this employee is working
        /// </summary>
        [System.ComponentModel.Browsable(false)] // This is an attribute, that disables visability of this field in data grid view
        public Guid AmmoShopId { get; set; }
        /// <summary>
        /// Ammo shop object, where this employee is working
        /// </summary>
        [System.ComponentModel.Browsable(false)] // This is an attribute, that disables visability of this field in data grid view
        public AmmoShop AmmoShop { get; set; }
        /// <summary>
        /// Purchases list, that this employee has placed
        /// </summary>
        public List<Purchases> Purchases { get; set; }

    }
}
