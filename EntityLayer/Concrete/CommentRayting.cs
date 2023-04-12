using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CommentRayting
    {
        [Key]
        public int ID { get; set; }
        public int BlogID { get; set; }
        public int CommentScrore { get; set; }
        public int CommentCount { get; set; }
    }
}
