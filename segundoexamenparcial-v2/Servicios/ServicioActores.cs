using System.Collections.Generic;
using System.Linq;
using segundoexamenparcial_v2.Modelo;
using segundoexamenparcial_v2.Data;
using Microsoft.EntityFrameworkCore;

namespace segundoexamenparcial_v2.Servicio
{   
    public class ServicioActores {
        private DvdContexto contexto;
        public ServicioActores(DvdContexto dvdContexto) => contexto = dvdContexto;

        public List<Actor> obtenerTodo(string cadenaBuscar) {
            var _actores = contexto.Actores;
            
            var actores = from a in _actores select a;
            if(!string.IsNullOrEmpty(cadenaBuscar)){
                actores = actores.Where(a=>a.Nombre.Contains(cadenaBuscar));
            }
            
            return actores.ToList();
        }

        public Actor Obtener(int Id){
            Actor actor = contexto.Actores.FirstOrDefault(a=>a.Id.Equals(Id));
            return actor;
        }
        public bool Insertar(Actor actor) {
            contexto.Actores.Add(actor);
            contexto.SaveChanges();
            return true;
        }
        public bool Actualizar(Actor actor) {
            contexto.Actores.Update(actor);
            contexto.SaveChanges();
            return true;
        }
        public bool Eliminar(Actor actor) {
            contexto.Actores.Remove(actor);
            contexto.SaveChanges();
            return true;
        }

    }
}