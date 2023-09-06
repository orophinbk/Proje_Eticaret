using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Context
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public string? CommentUser { get; set; }
        public DateTime CommentDate { get; set; }
        public string? CommentContent { get; set; }
        public bool CommentState { get; set; }
        public int ProductID { get; set; }
        public virtual Product? Products { get; set; }
    }
}
