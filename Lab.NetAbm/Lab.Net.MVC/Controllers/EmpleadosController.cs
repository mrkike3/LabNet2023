using Lab.Net.Entities;
using Lab.Net.Logic;
using Lab.Net.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.Net.MVC.Controllers
{
    public class EmpleadosController : Controller
    {
        private EmpleadoServicio _empleadoServicio  = new EmpleadoServicio();
        // GET: Empleados
        public ActionResult Index()
        {
            IEnumerable<EmpleadoDto> resultado = _empleadoServicio.GetAll();

            return View(resultado);
        }

        public ActionResult InsertarEmpleado()
        {
            

            return View();
        }

        [HttpPost]
        public ActionResult InsertarEmpleado(EmpleadoView view)
        {

            try
            {
                var nuevoEmpleado = new EmpleadoDto 
                {
                    Nombre = view.Nombre,
                    Apellido = view.Apellido
                };

                _empleadoServicio.Insertar(nuevoEmpleado);
                return RedirectToAction("Index");
                
            }
            catch (Exception)
            {

                return RedirectToAction("Index", "Error");
            }


           
        }


    }
}