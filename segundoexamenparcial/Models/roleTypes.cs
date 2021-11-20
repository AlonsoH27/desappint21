using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace segundoexamenparcial.Modelo
{
    public class roleTypes {
        [Key]
        public int roleTypeId {get; set;}
        [Required(ErrorMessage = "Se requiere role type"), StringLength(60,ErrorMessage = "Longitud Maxima 60")]
        public string roleType {get; set;}

        public ICollection<filmsActorRoles> filmsActoresRoles {get; set;}

    }
}