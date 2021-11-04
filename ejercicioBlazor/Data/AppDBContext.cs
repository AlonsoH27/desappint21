using System;
using Microsoft.EntityFrameworkCore;

namespace ejercicioBlazor.Data
{   
    public class AppDBContext : DbContext {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options){

        }
        public DbSet<Movie> Movie {get; set;}
    }
    
}