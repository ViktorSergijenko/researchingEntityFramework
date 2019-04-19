using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class Customer : BaseEntity
    {
        Customer()
        {
            Purchases = new List<Purchases>();
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string PersCode { get; set; }
        public string LicenseNumber { get; set; }
        public List<Purchases> Purchases { get; set; }

    }
}
