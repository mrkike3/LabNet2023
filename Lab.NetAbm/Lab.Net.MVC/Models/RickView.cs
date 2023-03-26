using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Razor.Generator;

namespace Lab.Net.MVC.Models
{
    public class RickView
    {
       public Image  Imagen { get; set; }
       public string Nombre { get; set; }
       public string Genero { get; set; }
       public string Estado { get; set; }  
    }
}