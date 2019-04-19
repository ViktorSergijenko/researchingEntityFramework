using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    /// <summary>
    /// Acessuary model
    /// </summary>
    class Acessuary : BaseEntity
    {
        /// <summary>
        /// Acessuary class constructor
        /// </summary>
        public Acessuary() {
            // This is made to avoid problems with null reference
            Purchases = new List<Purchases>();
        }
        /// <summary>
        /// Name of acessuary
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Price per one acessuary
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// List of purchases where this acessuary was purchased
        /// </summary>
        public List<Purchases> Purchases { get; set; }
    }
}
