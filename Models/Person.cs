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
        [Required(ErrorMessage = "O {0} é obrigatório")]
        public String Name { get; set; }

        [Column("Email")]
        [Display(Name = "Email")]
        [Required (ErrorMessage = " O {0} é obrigatório")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; }

        [Column("Number")]
        [Display(Name = "Número")]
        [Required(ErrorMessage = "O {0} é obrigatório")]
        [Range(800000000,long.MaxValue,ErrorMessage ="Número inválido")]
        public long Number { get; set; }
    }
}
