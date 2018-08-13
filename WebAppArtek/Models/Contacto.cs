using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppArtek.Models
{
    public class Contacto
    {
        [Key]
        public int Id_Contacto { get; set; }
        [Display(Name = "Nombre del contacto")]
        [StringLength(50,
       ErrorMessage = "El campo {0} debe estar entre {2} y {1} caracteres"
       , MinimumLength = 3)]
        [Required(ErrorMessage = "Debe ingresar {0}")]
        public string Cont_Nombre { get; set; }
        public EstadoContacto Cont_Estado { get; set; }
        public virtual ClienteExterno Id_ClienteExterno { get; set; }
    }
}