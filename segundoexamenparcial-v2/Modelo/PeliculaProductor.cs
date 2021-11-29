using System.ComponentModel.DataAnnotations;

namespace segundoexamenparcial_v2.Modelo
{
    public class PeliculaProductor {
        [Key]
        public int ProductorId {get; set;}
        [Required]
        public int PeliculaId {get; set;}

        public Productor Productor {get; set;}
        public Pelicula Pelicula {get; set;}

    }
}