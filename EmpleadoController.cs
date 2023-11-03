using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication2.Context;
using WebApplication2.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("api/empleado")]
    public class EmpleadoController : ControllerBase
    {
        private readonly ILogger<EmpleadoController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;

        public EmpleadoController(
            ILogger<EmpleadoController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }

        // Create: Crear empleado
        [HttpPost]
        public IActionResult Post([FromBody] Empleado empleado)
        {
            _aplicacionContexto.Empleado.Add(empleado);
            _aplicacionContexto.SaveChanges();
            return Ok(empleado);
        }

        // Read: Obtener lista de empleados
        [HttpGet]
        public IEnumerable<Empleado> Get()
        {
            return _aplicacionContexto.Empleado.ToList();
        }

        // Update: Modificar empleado
        [HttpPut]
        public IActionResult Put([FromBody] Empleado empleado)
        {
            _aplicacionContexto.Empleado.Update(empleado);
            _aplicacionContexto.SaveChanges();
            return Ok(empleado);
        }

        // Delete: Eliminar empleado por ID
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var empleado = _aplicacionContexto.Empleado.FirstOrDefault(e => e.IdEmpleado == id);

            if (empleado != null)
            {
                _aplicacionContexto.Empleado.Remove(empleado);
                _aplicacionContexto.SaveChanges();
                return Ok(id);
            }
            else
            {
                return NotFound($"Empleado con ID {id} no encontrado.");
            }
        }
    }
}
