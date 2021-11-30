using System.Collections.Generic;
using System.Linq;
using segundoexamenparcial_v2.Modelo;
using segundoexamenparcial_v2.Data;
using Microsoft.EntityFrameworkCore;

namespace segundoexamenparcial_v2.Servicio
{
    public class ServicioRoles {
        private DvdContexto contexto;
        public ServicioRoles(DvdContexto dvdContexto) => contexto = dvdContexto;

        public List<Rol> obtenerTodo(string cadenaBuscar) {
            var _roles = contexto.Roles;

            var roles = from r in _roles select r;

            return roles.ToList();
        }
    
        public Rol Obtener(int Id){
            Rol rol = contexto.Roles.FirstOrDefault(a=>a.Id.Equals(Id));
            return rol;
        }
        public bool Insertar(Rol rol) {
            contexto.Roles.Add(rol);
            contexto.SaveChanges();
            return true;
        }
        public bool Actualizar(Rol rol) {
            contexto.Roles.Update(rol);
            contexto.SaveChanges();
            return true;
        }
        public bool Eliminar(Rol rol) {
            contexto.Roles.Remove(rol);
            contexto.SaveChanges();
            return true;
        }

    
    }
}