using AmigosRESTAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using AmigosRESTAPI.Models;
using NetTopologySuite.Geometries;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;
using ControllerBase = Microsoft.AspNetCore.Mvc.ControllerBase;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;
using HttpPutAttribute = Microsoft.AspNetCore.Mvc.HttpPutAttribute;
using System.Data.Entity;
using HttpDeleteAttribute = Microsoft.AspNetCore.Mvc.HttpDeleteAttribute;
using System.Data.Entity.Infrastructure;

namespace AmigosRESTAPI.Models
{
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