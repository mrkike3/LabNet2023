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

        [StringLength(20)]
        public string Nombre { get; set; }

       
        [Required]

        [StringLength(20)]
        public string Apellido { get; set; }
    }
}