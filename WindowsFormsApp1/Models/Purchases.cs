using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class Purchases : BaseEntity
    {
        public Weapon Weapon { get; set; }
        public Acessuary Acessuary { get; set; }
        public Ammo Ammo { get; set; }
        public Customer Customer { get; set; }
        public Employee Employee { get; set; }
        public AmmoShop AmmoShop { get; set; }
        public Guid AmmoId { get; set; }
        public Guid WeaponId { get; set; }
        public Guid AcessuaryId { get; set; }
        public Guid AmmoShopId { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid CustomerId { get; set; }
        public int AmountOfAmmo { get; set; }
        public int AmountOfWeapon { get; set; }
        public int AmountOfAcessuary { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
