using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IDGS904_BD.Models
{
    public class Alumnos
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public String Nombre { get; set; }
        [Required]
        [StringLength(100)]
        public String Apellidos { get; set; }
        [StringLength(50)]
        public String Correo { get; set; }
    }
}