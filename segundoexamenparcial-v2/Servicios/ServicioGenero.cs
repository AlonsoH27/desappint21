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
        

    }
}