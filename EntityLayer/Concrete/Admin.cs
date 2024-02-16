using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }

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
        [StringLength(12, MinimumLength = 5, ErrorMessage = "Username length must be between 5 and 8 characters.")]
        public string Username { get; set; }

        [Column(TypeName = "nvarchar")]
        [Required(ErrorMessage = "Password field is required.")]
        [StringLength(12, MinimumLength = 6, ErrorMessage = "Password length must be between 6 and 12 characters.")]
        public string Password { get; set; }
        public bool Status { get; set; }
        [Column(TypeName = "char")]
        [StringLength(1, MinimumLength = 1, ErrorMessage = "The role must be a single character.")]
        public string Role { get; set; }
    }
}
