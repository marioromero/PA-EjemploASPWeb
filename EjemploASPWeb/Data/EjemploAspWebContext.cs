using Microsoft.EntityFrameworkCore;

namespace EjemploASPWeb.Data
{
    public class EjemploAspWebContext : DbContext
    {
        public EjemploAspWebContext(DbContextOptions<EjemploAspWebContext> options) : base(options)
        {
        }

        public DbSet<EjemploASPWeb.Models.Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
