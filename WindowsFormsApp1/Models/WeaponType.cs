using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    /// <summary>
    /// Weapon type model
    /// </summary>
    class WeaponType : BaseEntity
    {
        
      /// <summary>
      /// Constructor of weapon type model
      /// </summary>
      public  WeaponType()
        {
            // This is made to avoid problems with null reference
            Weapons = new List<Weapon>();
            Ammo = new List<Ammo>();
        }
        /// <summary>
        /// Name of weapon type
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// List of weapons with this kind of weapon type
        /// </summary>
        public List<Weapon> Weapons { get; set; }
        /// <summary>
        /// List of ammo that has this kind of weapon type
        /// </summary>
        public List<Ammo> Ammo { get; set; }
    }
}
