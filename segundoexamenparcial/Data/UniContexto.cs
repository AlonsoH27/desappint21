using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using segundoexamenparcial.Modelo;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace segundoexamenparcial.Data
{
    public class UniContexto : IdentityDbContext<Usuario> {
        public UniContexto(DbContextOptions<UniContexto> opciones) : base(opciones){

        }
        public DbSet<Actor> Actors {get;set;}
        public DbSet<filmCertificates> filmsCertificates {get;set;}
        public DbSet<filmGenres> filmsGenres {get;set;}
        public DbSet<filmsActorRoles> filmsActorsRoles {get;set;}
        public DbSet<filmTitles> filmsTitles {get;set;}
        public DbSet<filmTitlesProducers> filmsTitlesProducers {get;set;}
        public DbSet<Producer> Producerss {get;set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}