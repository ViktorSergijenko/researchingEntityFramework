using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    /// <summary>
    ///  Weapon model
    /// </summary>
    class Weapon : BaseEntity
    {
       /// <summary>
       /// Weapon class constructor
       /// </summary>
       public  Weapon()
        {
            // This is made to avoid problems with null reference
            Purchases = new List<Purchases>();
        }
        /// <summary>
        /// Weapon name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Object of weapon type, that this weapon is belong to
        /// </summary>
        [System.ComponentModel.Browsable(false)] // This is an attribute, that disables visability of this field in data grid view
        public WeaponType WeaponType { get; set; }
        /// <summary>
        /// Id of an weapon type, that this weapon belongs too
        /// </summary>
        [System.ComponentModel.Browsable(false)] // This is an attribute, that disables visability of this field in data grid view
        public Guid WeaponTypeId { get; set; }
        /// <summary>
        /// Weapon price
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// List of purchases where, this weapon was purchased
        /// </summary>
        public List<Purchases> Purchases { get; set; }
    }
}
