using System.Collections.Generic;
using System.Linq;
using segundoexamenparcial_v2.Modelo;
using segundoexamenparcial_v2.Data;
using Microsoft.EntityFrameworkCore;

namespace segundoexamenparcial_v2.Servicio
{
    public class ServicioPeliculaActorRol {
        private DvdContexto contexto;
        public ServicioPeliculaActorRol(DvdContexto dvdContexto) => contexto = dvdContexto;
        
        public List<PeliculaActorRol> obtenerTodo(string cadenaBuscar){
            var _peliculaActorRol = contexto.PeliculaActorRol;

            var peliculaActorRol = from par in _peliculaActorRol select par;

            return peliculaActorRol.ToList();
        }

        public PeliculaActorRol Obtener(int Id){
            PeliculaActorRol peliculaActorRol = contexto.PeliculaActorRol.FirstOrDefault(par=>par.PeliculaId.Equals(Id));
            return peliculaActorRol;
        }
        public bool Insertar(PeliculaActorRol peliculaActorRol) {
            contexto.PeliculaActorRol.Add(peliculaActorRol);
            contexto.SaveChanges();
            return true;
        }
        public bool Actualizar(PeliculaActorRol peliculaActorRol) {
            contexto.PeliculaActorRol.Update(peliculaActorRol);
            contexto.SaveChanges();
            return true;
        }
        public bool Eliminar(PeliculaActorRol peliculaActorRol) {
            contexto.PeliculaActorRol.Remove(peliculaActorRol);
            contexto.SaveChanges();
            return true;
        }

    }
}