using AmigosRESTAPI.Models;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace AmigosRESTAPI.Controllers {
    public class AppAmigosContext : DbContext
    {
        public AppAmigosContext(DbContextOptions<AppAmigosContext> options) : base(options)
        {
        }

        public DbSet<Utilizador> Utilizadores { get; set; }
        public DbSet<Localizacao> Localizacoes { get; set; }
        public DbSet<Notificacao> Notificacoes { get; set; }
        public DbSet<Mensagem> Mensagens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("postgis");

            modelBuilder.Entity<Localizacao>()
                .Property(l => l.Localizacao)
                .HasColumnType("geometry(Point, 4326)")
                .HasConversion(
                    p => new Point(p.Longitude, p.Latitude) { SRID = 4326 },
                    p => new Localizacao { Localizacao = new Point(p.X, p.Y) { SRID = 4326 } }
                );
        }
    }
}