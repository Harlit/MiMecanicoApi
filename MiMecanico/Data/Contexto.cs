using Microsoft.EntityFrameworkCore;
using MiMecanico.Models;

namespace MiMecanico.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Mecanicos> Mecanicos => Set<Mecanicos>();
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
        }
    }
}
