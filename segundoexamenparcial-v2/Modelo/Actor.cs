using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace segundoexamenparcial_v2.Modelo
{
    public class Actor {
        [Key]
        public int Id {get; set;}
        [Required]
        public string Nombre {get; set;}
        public string Notas {get; set;}

        public ICollection<PeliculaActorRol> PeliculaActorRoles {get; set;}
        

    }
}