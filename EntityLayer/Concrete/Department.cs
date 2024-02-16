using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Department
    {
        [Key]
        public int SecretaryID { get; set; }

        [Column(TypeName = "nvarchar")]
        [Required(ErrorMessage = "Department name field is required.")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Department name length must be between 2 and 30 characters.")]
        public string Name { get; set; }

        public bool Status { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
        public ICollection<Secretary> Secretaries { get; set; }

    }
}
