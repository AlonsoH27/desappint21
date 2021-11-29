using Microsoft.EntityFrameworkCore;
using segundoexamenparcial_v2.Modelo;

namespace segundoexamenparcial_v2
{
    public class DvdContexto : DbContext {
        public DvdContexto(DbContextOptions<DvdContexto> opciones)
            : base(opciones) {}

        public DbSet<Actor> Actores {get; set;}
        public DbSet<Certificado> Certificados {get; set;}
        public DbSet<Genero> Generos {get; set;}
        public DbSet<Pelicula> Pelicula {get; set;}
        public DbSet<PeliculaActorRol> PeliculaActorRol {get; set;}
        public DbSet<PeliculaProductor> PeliculaProductor {get; set;}
        public DbSet<Rol> Roles {get; set;}
        public DbSet<Productor> Productores {get; set;}

        protected override void OnModelCreating(ModelBuilder model) {
            model.Entity<PeliculaActorRol>().HasKey(k=> new{k.PeliculaId, k.ActorId, k.RolId});
            model.Entity<PeliculaProductor>().HasKey(k=> new {k.ProductorId, k.PeliculaId});
        }

    }
}