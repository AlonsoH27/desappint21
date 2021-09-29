using System;
using Microsoft.EntityFrameworkCore;

namespace p20_blazorcrud.Data {
    public class AppDBContext : DbContext {
        public AppContext(DbContextOptions<AppDBContext> options) : base(options) {

        }
        public DbSet<Employee> Employees {get; set;}
    }
}