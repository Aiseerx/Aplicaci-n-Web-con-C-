using Microsoft.AspNetCore.Mvc;
using WebApplication2.Context;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Departamento : ControllerBase
    {
        private readonly ILogger<Departamento> _logger;
        private readonly AplicacionContexto _AplicacionContexto;
        public Departamento(
            ILogger<Departamento> logger, 
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _AplicacionContexto = aplicacionContexto;
        }
        //Create: Crear Departamento
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Departamento departamento)
        {
            _AplicacionContexto.Departamento.Add(departamento);
            _AplicacionContexto.SaveChanges();
            return Ok(departamento);
        }
        //READ: Obtener lista de departamento
        [Route("")]
        [HttpGet]
        public IEnumerable<Departamento> Get()
        {
            return _AplicacionContexto.Departamento.ToList();
        }
        //Update: Modificar departamento
        [Route("/id")]
        [HttpPut]
        public IActionResult Put([FromBody] Departamento departamento)
        {
            _AplicacionContexto.Departamento.Update(departamento);
            _AplicacionContexto.SaveChanges();
            return Ok(departamento);
        }
        //Delete: Eliminar departamento
        [Route("/id")]
        [HttpDelete]
        public IActionResult Delete(int departamentoID)
        {
            _AplicacionContexto.Departamento.Remove(
                _AplicacionContexto.Departamento.ToList()
                .Where(x=>x.idDepartamento== departamentoID)
                .FirstOrDefault());
            _AplicacionContexto.SaveChanges();
            return Ok(departamentoID);
        }
    }
}