using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Context
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string? Image { get; set; }
        public bool Slider { get; set; }
        public int CategoryID { get; set; }

        public virtual Category? Category { get; set; }
        public virtual ICollection<Comment>? Comments { get; set; }
    }
}
