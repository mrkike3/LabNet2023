using Lab.Net.Entities;
using Lab.Net.Logic;
using Lab.Net.Logic.Categoria;
using Lab.Net.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Lab.Net.WebApi.Controllers
{
    public class EmpleadosController : ApiController
    {
        private EmpleadoServicio _empleadoServicio = new EmpleadoServicio();
        private EmpleadoDto _empleadoDto = new EmpleadoDto();
        private EmpleadoView _empleadoView = new EmpleadoView();
        // GET: Empleados
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(_empleadoServicio.GetAll());
            }
            catch (Exception)
            {

                return BadRequest("Ocurrio un error al obtener los empleados");
            }
           
        }

        public IHttpActionResult GetbyId(int id)
        {
            try
            {
                var empleado = _empleadoServicio.ObtenerPorId(id);

                _empleadoDto.Id = empleado.EmployeeID;
                _empleadoDto.Nombre = empleado.FirstName;
                _empleadoDto.Apellido = empleado.LastName;

              
                return Ok(_empleadoDto);
            }
            catch (Exception)
            {
                return BadRequest("No existe un empleado con ese Id.");
            }
        }

        public IHttpActionResult Post([FromBody] EmpleadoView _empleadoView)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _empleadoDto.Nombre = _empleadoView.Nombre;
                    _empleadoDto.Apellido = _empleadoView.Apellido;
                    _empleadoServicio.Insertar(_empleadoDto);
    
                    return Ok("El empleado se inserto correctamente");
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception)
            {
                return BadRequest("ocurrio un error al insertar el empleado");
            }
        }

        public IHttpActionResult Put([FromBody] EmpleadoView _empleadoView)
        {
            try
            {
                if (ModelState.IsValid)
                {
                var empleadoModificado = new EmpleadoDto
                {
                    Id = _empleadoView.Id,
                    Nombre = _empleadoView.Nombre,
                    Apellido = _empleadoView.Apellido
                };
                _empleadoServicio.Modificar(empleadoModificado);

                return Ok("El empleado se modifico correctamente");
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception)
            {

                return BadRequest("ocurrio un error no existe empleado con ese id");
            }
            
          
        }

        public IHttpActionResult Delete(decimal Id)
        {
            try
            {

            _empleadoServicio.Eliminar(Id);
            return Ok("Empleado eliminado");
            }
            catch (Exception)
            {

                return BadRequest("ocurrio un error al eliminar el empleado o no existe empleado con el id solicitado");
            }
        }

    }
}