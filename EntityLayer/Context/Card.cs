using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Context
{
    public class Card
    {
        public int CardID { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string? ProductName { get; set; }
        public string? ProductImage { get; set; }
        public int ProductID { get; set; }
        public virtual Product? Product { get; set; }
    }
}
