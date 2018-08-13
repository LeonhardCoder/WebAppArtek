using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppArtek.Models
{
    public class Materiales
    {
        [Key]
        public int Id_Materiales { get; set; }

        public string Mat_Nombre { get; set; }

        public string Mat_Descripcion { get; set; }

        public string Mat_Estado { get; set; }
    }
}