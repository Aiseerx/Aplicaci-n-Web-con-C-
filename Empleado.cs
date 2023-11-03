namespace WebApplication2.Models
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public char Genero { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int IdSeguro { get; set; }
        public int IdSalario { get; set; }
        public int IdDepartamento { get; set; }
    }
}
