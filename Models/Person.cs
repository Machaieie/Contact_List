using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_MVC_PhoneList.Models
{
    [Table("Contactos")]
    public class Person
    {
        [Key]
        [Column("Id")]
        [Display (Name = "ID")]
        public int ID { get; set; }

        [Column("Name")]
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "{0} is required")]
        public String Name { get; set; }

        [Column("Email")]
        [Display(Name = "Email")]
        [Required (ErrorMessage ="{0} is required")]
        [EmailAddress(ErrorMessage ="invalid email")]
        public string Email { get; set; }

        [Column("Number")]
        [Display(Name = "Número")]
        [Required(ErrorMessage = "{0} is required")]
        [Range(800000000,long.MaxValue,ErrorMessage ="Number invalid")]
        public long Number { get; set; }
    }
}
