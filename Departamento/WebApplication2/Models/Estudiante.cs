using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Departamneto
    {
        [Key]
        public int idDepartamento { get; set; }
        public string Nombre { get; set; }
        public int Area { get; set; }
        
    }
}