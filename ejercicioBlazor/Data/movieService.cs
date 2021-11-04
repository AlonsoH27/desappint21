using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ejercicioBlazor.Data   
{
    public class movieService{
        
        private AppDBContext _appDBContext;

        public movieService(AppDBContext appDBContext) => _appDBContext = appDBContext;

        //Obtener todas las peliculas
        public List<Movie> GetAllMovie() => _appDBContext.Movie.ToList();

        //Obtener una sola pelicula 
        public Movie GetMovie(int Id){
            Movie movie = _appDBContext.Movie.FirstOrDefault(c=>c.Id.Equals(Id));
            return movie;
        }

        //Insertr pelicula
        public bool insertMovie(Movie movie) {
            _appDBContext.Movie.Add(movie);
            _appDBContext.SaveChanges();
            return true;
        }
        public bool updateMovie(Movie movie){
            _appDBContext.Movie.Update(movie);
            _appDBContext.SaveChanges();
            return true;
        }
        public bool deleteMovie(Movie movie){
            _appDBContext.Movie.Remove(movie);
            _appDBContext.SaveChanges();
            return true;
        }

    }
}