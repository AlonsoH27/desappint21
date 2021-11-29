using System.Collections.Generic;
using System.Linq;
using segundoexamenparcial_v2.Modelo;
using segundoexamenparcial_v2.Data;
using Microsoft.EntityFrameworkCore;

namespace segundoexamenparcial_v2.Servicio
{   
    public class ServicioCertificados {
        private DvdContexto contexto;
        public ServicioCertificados(DvdContexto dvdContexto) => contexto = dvdContexto;

        public List<Certificado> obtenerTodo(string cadenaBuscar) {
            var _certificados = contexto.Certificados;
            
            var certificados = from a in _certificados select a;
            if (!string.IsNullOrEmpty(cadenaBuscar))
            {
                certificados = certificados.Where(c=>c.Descripcion.Contains(cadenaBuscar));
            }
            
            return certificados.ToList();
        }

        public Certificado Obtener(int Id){
            Certificado certificado = contexto.Certificados.FirstOrDefault(a=>a.Id.Equals(Id));
            return certificado;
        }
        public bool Insertar(Certificado certificado) {
            contexto.Certificados.Add(certificado);
            contexto.SaveChanges();
            return true;
        }
        public bool Actualizar(Certificado certificado) {
            contexto.Certificados.Update(certificado);
            contexto.SaveChanges();
            return true;
        }
        public bool Eliminar(Certificado certificado) {
            contexto.Certificados.Remove(certificado);
            contexto.SaveChanges();
            return true;
        }

    }
}