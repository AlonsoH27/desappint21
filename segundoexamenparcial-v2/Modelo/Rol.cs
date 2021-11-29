using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace segundoexamenparcial_v2.Modelo
{
    public class Rol {
        [Key]
        public int Id {get; set;}
        [Required]
        public string Tipo {get; set;}

        public ICollection<PeliculaActorRol> PeliculaActorRoles {get; set;}

    }
}