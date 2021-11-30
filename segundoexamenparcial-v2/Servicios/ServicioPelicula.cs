using System.Collections.Generic;
using System.Linq;
using segundoexamenparcial_v2.Modelo;
using segundoexamenparcial_v2.Data;
using Microsoft.EntityFrameworkCore;

namespace segundoexamenparcial_v2.Servicio
{
    public class ServicioPelicula {
        private DvdContexto contexto;
        public ServicioPelicula(DvdContexto dvdContexto) => contexto = dvdContexto;
 
        public List<Pelicula> obtenerTodo(string cadenaBuscar){
            var _pelicula = contexto.Pelicula
            .Include(g=>g.Genero)
                .Include(c=>c.Certificado);

            var peliculas = from p in _pelicula select p;

            return peliculas.ToList();
        }

        public Pelicula Obtener(int Id){
            Pelicula pelicula = contexto.Pelicula.FirstOrDefault(a=>a.Id.Equals(Id));
            return pelicula;
        }
        public bool Insertar(Pelicula pelicula) {
            contexto.Pelicula.Add(pelicula);
            contexto.SaveChanges();
            return true;
        }
        public bool Actualizar(Pelicula pelicula) {
            contexto.Pelicula.Update(pelicula);
            contexto.SaveChanges();
            return true;
        }
        public bool Eliminar(Pelicula pelicula) {
            contexto.Pelicula.Remove(pelicula);
            contexto.SaveChanges();
            return true;
        }


    }
}