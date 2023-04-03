using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab.Net.MVC.Models
{
    public class EmpleadoView
    {
        public int Id { get; set; }

        [Required]

        [StringLength(10)]
        [RegularExpression("^[a-zA-Z\\s]+$", ErrorMessage = "El nombre de empleado no acepta valores numericos ni simbolos")]
        public string Nombre { get; set; }

       
        [Required]

        [StringLength(20)]
        [RegularExpression("^[a-zA-Z\\s]+$", ErrorMessage = "El apellido de empleado no acepta valores numericos ni simbolos")]
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public DateTime FechaContratacion { get; set; }
        public string Pais { get; set; }
    }
}
