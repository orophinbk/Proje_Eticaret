using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Context
{
    public class Pay
    {
        [Key]
        public int PayID { get; set; }
        public string? UserName { get; set; }
        public string? CartNumber { get; set; }
        public string? SecurityNumber { get; set; }
        public string? CartHasName { get; set; }
        public int ExpYear { get; set; }
        public int ExpMonth { get; set; }
    }
}
