using System.ComponentModel.DataAnnotations;

namespace segundoexamenparcial_v2.Modelo
{
    public class PeliculaProductor {
        [Key]
        public int Id {get; set;}
        public int ProductorId {get; set;}
        public int PeliculaId {get; set;}

        public Productor Productor {get; set;}
        public Pelicula Pelicula {get; set;}

    }
}