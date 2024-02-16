using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Patient
    {
        [Key]
        public int PatientID { get; set; }

        [Column(TypeName = "nvarchar")]
        [Required(ErrorMessage = "Name field is required.")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Name length must be between 2 and 30 characters.")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar")]
        [Required(ErrorMessage = "Surname field is required.")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Surname length must be between 2 and 30 characters.")]
        public string Surname { get; set; }

        [Column(TypeName = "varchar")]
        [Required(ErrorMessage = "Identity number is required.")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "Identity number must be 11 digits.")]
        public string IdentityNumber { get; set; }

        [Column(TypeName = "nvarchar")]
        [Required(ErrorMessage = "Password field is required.")]
        [StringLength(12, MinimumLength = 6, ErrorMessage = "Password length must be between 6 and 12 characters.")]
        public string Password { get; set; }
        public bool Status { get; set; }

        [StringLength(300)]
        public string Complaint { get; set; }

        public Doctor Doctor { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }
}
