using System.Collections.Generic;
using System.Linq;
using segundoexamenparcial_v2.Modelo;
using segundoexamenparcial_v2.Data;
using Microsoft.EntityFrameworkCore;

namespace segundoexamenparcial_v2.Servicio
{
    public class ServicioGenero {
        private DvdContexto contexto;
        public ServicioGenero(DvdContexto dvdContexto) => contexto = dvdContexto;
        
        public List<Genero> obtenerTodo(string cadenaBuscar){
            var _generos = contexto.Generos;

            var generos = from g in _generos select g;
            
            return generos.ToList();
        }

        public Genero Obtener(int Id){
            Genero genero = contexto.Generos.FirstOrDefault(g=>g.Id.Equals(Id));
            return genero;
        }
        public bool Insertar(Genero genero) {
            contexto.Generos.Add(genero);
            contexto.SaveChanges();
            return true;
        }
        public bool Actualizar(Genero genero) {
            contexto.Generos.Update(genero);
            contexto.SaveChanges();
            return true;
        }
        public bool Eliminar(Genero genero) {
            contexto.Generos.Remove(genero);
            contexto.SaveChanges();
            return true;
        }

    }
}