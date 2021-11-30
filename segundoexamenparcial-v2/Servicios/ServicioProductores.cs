using System.Collections.Generic;
using System.Linq;
using segundoexamenparcial_v2.Modelo;
using segundoexamenparcial_v2.Data;
using Microsoft.EntityFrameworkCore;

namespace segundoexamenparcial_v2.Servicio
{
    public class ServicioProductores {
        private DvdContexto contexto;
        public ServicioProductores(DvdContexto dvdContexto) => contexto = dvdContexto;

        public List<Productor> obtenerTodo(string cadenaBuscar) {
            var _productores = contexto.Productores;

            var productores = from p in _productores select p;

            return productores.ToList();
        }

        public Productor Obtener(int Id){
            Productor productor = contexto.Productores.FirstOrDefault(a=>a.Id.Equals(Id));
            return productor;
        }
        public bool Insertar(Productor productor) {
            contexto.Productores.Add(productor);
            contexto.SaveChanges();
            return true;
        }
        public bool Actualizar(Productor productor) {
            contexto.Productores.Update(productor);
            contexto.SaveChanges();
            return true;
        }
        public bool Eliminar(Productor productor) {
            contexto.Productores.Remove(productor);
            contexto.SaveChanges();
            return true;
        }

    }
}