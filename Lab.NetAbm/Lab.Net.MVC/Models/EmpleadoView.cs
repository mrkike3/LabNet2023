using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab.Net.MVC.Models
{
    public class EmpleadoView
    {
        public long Id { get; set; }

        [Required(ErrorMessage ="El nombre es requerido")]

        [StringLength(20)]
        public string Nombre { get; set; }

       
        [Required(ErrorMessage = "El apellido es requerido")]

        [StringLength(20)]
        public string Apellido { get; set; }
    }
}