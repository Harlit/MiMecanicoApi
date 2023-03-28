using Microsoft.EntityFrameworkCore;
using MiMecanico.Models;

namespace MiMecanico.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet <Mecanicos> Mecanicos => Set<Mecanicos>();
        public DbSet <Clientes> Clientes => Set<Clientes>();
        public DbSet <Reportes> Reportes => Set<Reportes>();
        public DbSet<CitaTaller> CitaTallers => Set<CitaTaller>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
        }


        public DbSet<MiMecanico.Models.Solicitudes> Solicitudes { get; set; } = default!;


        public DbSet<MiMecanico.Models.Vehiculos> Vehiculos { get; set; } = default!;
    }
}
