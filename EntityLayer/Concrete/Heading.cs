using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Heading
    {
        [Key]
        public int HeadingID { get; set; }
        [StringLength(200)]
        public string Title { get; set; }
        public bool IsActive { get; set; }
        public int InfoID { get; set; }
        public HeadingInfo HeadingInfo { get; set; }
    }
}
