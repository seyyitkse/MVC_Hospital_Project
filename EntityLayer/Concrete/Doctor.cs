using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Doctor
    {
        [Key]
        public int DoctorID { get; set; }

        [Column(TypeName = "nvarchar")]
        [Required(ErrorMessage = "Name field is required.")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Name length must be between 2 and 30 characters.")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar")]
        [Required(ErrorMessage = "Surname field is required.")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Surname length must be between 2 and 30 characters.")]
        public string Surname { get; set; }

        [Column(TypeName = "nvarchar")]
        [Required(ErrorMessage = "Username field is required.")]
        [StringLength(12, MinimumLength = 5, ErrorMessage = "Username length must be between 5 and 12 characters.")]
        public string Username { get; set; }

        [Column(TypeName = "nvarchar")]
        [Required(ErrorMessage = "Password field is required.")]
        [StringLength(12, MinimumLength = 6, ErrorMessage = "Password length must be between 6 and 12 characters.")]
        public string Password { get; set; }
        public bool Status { get; set; }
        public int DepartmanID { get; set; }
        public Department Department { get; set; }
        public ICollection<Patient> Patients { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }
}
