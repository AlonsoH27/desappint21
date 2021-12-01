using System.Collections.Generic;
using System.Linq;
using segundoexamenparcial_v2.Modelo;
using segundoexamenparcial_v2.Data;
using Microsoft.EntityFrameworkCore;

namespace segundoexamenparcial_v2.Servicio
{   
    public class ServicioPeliculaProductor {
        private DvdContexto contexto;
        public ServicioPeliculaProductor(DvdContexto dvdContexto) => contexto = dvdContexto;

        public List<PeliculaProductor> obtenerTodo(string cadenaBuscar){
            var _peliculaProductores = contexto.PeliculaProductor;

            var peliculaProductores = from pp in _peliculaProductores select pp;

            return peliculaProductores.ToList();
        }

        public PeliculaProductor Obtener(int Id){
            PeliculaProductor peliculaProductor = contexto.PeliculaProductor.FirstOrDefault(a=>a.Id.Equals(Id));
            return peliculaProductor;
        }
        public bool Insertar(PeliculaProductor peliculaProductor) {
            contexto.PeliculaProductor.Add(peliculaProductor);
            contexto.SaveChanges();
            return true;
        }
        public bool Actualizar(PeliculaProductor peliculaProductor) {
            contexto.PeliculaProductor.Update(peliculaProductor);
            contexto.SaveChanges();
            return true;
        }
        public bool Eliminar(PeliculaProductor peliculaProductor) {
            contexto.PeliculaProductor.Remove(peliculaProductor);
            contexto.SaveChanges();
            return true;
        }

    }
}