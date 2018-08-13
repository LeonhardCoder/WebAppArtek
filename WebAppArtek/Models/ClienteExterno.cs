using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppArtek.Models
{
    public class ClienteExterno
    {
        [Key]
        public int Id_ClienteExterno { get; set; }

        [Display(Name = "Nombre Cliente")]
        [StringLength(50,
         ErrorMessage = "the field {0} must be between {2} and {1} characters"
         , MinimumLength = 3)]
        [Required(ErrorMessage = "You must enter {0}")]
        public string CExt_Nombre { get; set; }

        [Display(Name = "Direccion")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "You must enter {0}")]
        public string CExt_Direccion { get; set; }

        [Display(Name = "Telefono")]
        [DataType(DataType.PhoneNumber)]
        public string CExt_Telefono { get; set; }

        [Display(Name = "Fecha de creacion")]
        [Required(ErrorMessage = "You must enter {0}")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime CExt_FechaCreacion { get; set; }

        [Display(Name = "Estado")]
        public EstadoCliente CExt_Estado { get; set; }

        public ICollection<Contacto> Contactos { get; set; }
    }
}