using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace p20_blazorcrud.Data {
    public class MovieService {

        private AppDBContext _appDBContext;
        
        public MovieService(AppDBContext appDBContext) => _appDBContext = appDBContext;

        // Obtener todos los empleados
        public List<Movie> GetAllMovie() => _appDBContext.Movies.ToList();

        // Obtener un solo empleado
        public Movie GetMovie(int Id) {
            Movie movie = _appDBContext.Movies.FirstOrDefault(c=>c.Id.Equals(Id));
            return movie;
        }
        
        // Insertar empleado
        public bool InsertMovie(Movie movie) {
            _appDBContext.Movies.Add(movie);
            _appDBContext.SaveChanges();
            return true;
        }

        // Actualizar un empleado
        public bool UpdateMovie(Movie movie) {
            _appDBContext.Movies.Update(movie);
            _appDBContext.SaveChanges();
            return true;
        }

        // Borrar un empleado
        public bool DeleteMovie(Movie movie) {
            _appDBContext.Movies.Remove(movie);
            _appDBContext.SaveChanges();
            return true;
        }
        
    }
}