using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace segundoexamenparcial_v2.Modelo
{
    public class Certificado {
        [Key]
        public int Id {get; set;}
        public string Descripcion {get; set;}
        
        public ICollection<Pelicula> Peliculas {get; set;}


    }
}