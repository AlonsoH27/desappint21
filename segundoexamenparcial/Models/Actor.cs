using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace segundoexamenparcial.Modelo
{
    public class Actor {
        [Key]
        public int actorId {get; set;}
        [Required(ErrorMessage = "Se requiere el nombre"), StringLength(60,ErrorMessage = "Longitud Maxima 60")]
        public string fullName {get; set;}
        public int actorNotes {get; set;}

        public ICollection<filmsActorRoles> filmsActoresRoles {get; set;}
    }
    
}
