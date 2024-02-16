using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class HeadingInfo
    {
        [Key]
        public int InfoID { get; set; }
        [StringLength(300)]
        public string Information { get; set; }
        public ICollection<Heading> Headings { get; set; }
    }
}
