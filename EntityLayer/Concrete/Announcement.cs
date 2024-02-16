using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Announcement
    {
        [Key]
        public int AnnouncementID { get; set; }

        [Column(TypeName = "nvarchar")]
        [Required(ErrorMessage ="Announcement field is required")]
        [StringLength(500, MinimumLength = 20, ErrorMessage = "Announcement length must be between 20 and 500  characters.")]
        public string AnnouncementText { get; set; }
    }
}
