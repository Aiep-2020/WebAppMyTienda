using Microsoft.EntityFrameworkCore;
using WebAppMyTienda.Models.Class;

namespace WebAppMyTienda
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        :base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<tbl_Ligas> Tbl_Ligas { get; set; }
        public DbSet<tbl_Equipo> tbl_Equipos { get; set; }
        public DbSet<Jugador> Jugadores { get; set; }

    }
}




