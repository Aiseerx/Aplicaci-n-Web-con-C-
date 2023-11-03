using Microsoft.EntityFrameworkCore;
using WebApplication2.Controllers;


namespace WebApplication2.Context
{
    public class AplicacionContexto : DbContext
    {
        public AplicacionContexto(DbContextOptions<AplicacionContexto> options)
            : base(options) { }

        public DbSet<Departamento> Departamento { get; set; }
    }
}
