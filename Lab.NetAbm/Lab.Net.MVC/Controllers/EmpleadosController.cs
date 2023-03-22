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
      

     
        public ActionResult Index()
        {
            IEnumerable<EmpleadoDto> resultado = _empleadoServicio.GetAll();

            return View(resultado);
        }
        public  ActionResult Insertar()
        {
            return View("InsertarModificar", new EmpleadoView());
        }

        public ActionResult Modificar(int id)
        {
            
            var empleadoObtenido = _empleadoServicio.ObtenerPorId(id);
            _empleadoVista.Id = empleadoObtenido.EmployeeID;
            _empleadoVista.Nombre = empleadoObtenido.FirstName;
            _empleadoVista.Apellido = empleadoObtenido.LastName;

            return View("InsertarModificar", _empleadoVista);
        }
       

        [HttpPost]
        public ActionResult InsertarModificar(EmpleadoView modelo)
        {
            if (ModelState.IsValid)
             {

            if (modelo.Id == 0)
            {
                
                var empleadoNuevo = (new EmpleadoDto
                {
                    Nombre = modelo.Nombre,
                    Apellido = modelo.Apellido
                });
                _empleadoServicio.Insertar(empleadoNuevo);
                return RedirectToAction("Index");
            }
            else
            {

                var empleadoModificado = new EmpleadoDto
                {
                    Id = modelo.Id,
                    Nombre = modelo.Nombre,
                    Apellido = modelo.Apellido
                };
                _empleadoServicio.Modificar(empleadoModificado);
                return RedirectToAction("Index");
            }
            
             }
            return View("InsertarModificar");
        }

        public ActionResult Eliminar(decimal id)
        {
            _empleadoServicio.Eliminar(id);
            return RedirectToAction("Index");
        }

      
    }
}