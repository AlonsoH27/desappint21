using System;
using Microsoft.EntityFrameworkCore;

namespace p20_blazorcrud.Data { 
    public class AppDBContext : DbContext {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) {

        }
        public DbSet<Movie> Movies {get; set;}
    }
}