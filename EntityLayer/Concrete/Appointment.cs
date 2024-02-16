using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Appointment
    {
        [Key]
        public int AppointmentID { get; set; }

        [Column(TypeName = "nvarchar")]
        [Required(ErrorMessage = "Appointment field is required")]
        [StringLength(500, MinimumLength = 20, ErrorMessage = "Appointment length must be between 20 and 500  characters.")]
        public string AppointmentText { get; set; }

        public int PatientID { get; set; }
        public Patient Patient { get; set; }

        public int DoctorID { get; set; }
        public Doctor Doctor { get; set; }
    }
}
