using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ejercicioBlazor.Data
{
    public class DbInitializer{

        public static void Inicializar(AppDBContext context){
            context.Database.EnsureCreated();
            if(context.Movie.Any()){
                return;
            }
            var movie = new Movie[] {
                new Movie {nameMovie="Cars",year=2010,gender="Animada", classification="A"},
                new Movie {nameMovie="Batman",year=2012,gender="Accion", classification="+15"},
                new Movie {nameMovie="Venom",year=2021,gender="Accion", classification="C+15"},
            };
            foreach(Movie mov in movie){
                context.Movie.Add(mov);
            }
            context.SaveChanges();
        }
    }
}