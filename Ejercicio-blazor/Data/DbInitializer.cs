using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace p20_blazorcrud.Data { 
    public class DbInitializer {

        public static void Inicializar(AppDBContext context) {
            context.Database.EnsureCreated();
            if(context.Movies.Any()) {
                return;
            }
            var movies = new Movie[] {
                new Movie {nameMovie="Batman", year=2010, classification="+15", category="Accion"}
            };
            foreach(Movie mov in movies) {
                context.Movies.Add(mov);
            }
            context.SaveChanges();
        }

    }
}