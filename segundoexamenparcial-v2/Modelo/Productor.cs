using System.ComponentModel.DataAnnotations;

namespace segundoexamenparcial_v2.Modelo
{
    public class Productor {
        [Key]
        public int Id {get; set;}
        [Required]
        public string Nombre {get; set;}
        public string Correo {get; set;}
        public string sitioWeb {get; set;}

    }
}