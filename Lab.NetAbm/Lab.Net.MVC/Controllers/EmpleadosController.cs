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
        private EmpleadoView _empleadoVista = new EmpleadoView();
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
                if (ModelState.IsValid)
                {
                    var nuevoEmpleado = new EmpleadoDto
                    {
                        Nombre = view.Nombre,
                        Apellido = view.Apellido
                    };

                    _empleadoServicio.Insertar(nuevoEmpleado);
                    return RedirectToAction("Index");

                }
                return View();

            }
            catch (Exception)
            {

                return RedirectToAction("Index", "Error");
            }


           
        }

       public ActionResult Eliminar(decimal id)
        {
            _empleadoServicio.Eliminar(id);
           return RedirectToAction("Index");
        }

        public ActionResult Modificar(int id)
        {
            try
            {
                var empleadoObtenido = _empleadoServicio.ObtenerPorId(id);
                _empleadoVista.Id = empleadoObtenido.EmployeeID;
                _empleadoVista.Nombre = empleadoObtenido.FirstName;
                _empleadoVista.Apellido = empleadoObtenido.LastName;
                
            }
            catch (NullReferenceException)
            {
                return RedirectToAction("Index", "Error");
            }


            return View(_empleadoVista);

        }

        [HttpPost]   
        
        public ActionResult Modificar(EmpleadoView view)
        {
            var empleadoModificado = new EmpleadoDto
            {   Id = view.Id,
                Nombre = view.Nombre,
                Apellido = view.Apellido
            };
            _empleadoServicio.Modificar(empleadoModificado);
            return RedirectToAction("Index");
        }


    }
}