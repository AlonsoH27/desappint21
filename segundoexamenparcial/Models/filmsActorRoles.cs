using System;
using System.ComponentModel.DataAnnotations;

namespace segundoexamenparcial.Modelo
{
    public class filmsActorRoles {
        [Key]
        public int filmsActorRolesId {get; set;}
        public int filmTitleId {get; set;}
        public int actorId {get; set;}
        public int roleTypeId {get; set;}
        [Required(ErrorMessage = "Se requiere character name"), StringLength(60,ErrorMessage = "Longitud Maxima 60")]
        public string characterName {get; set;}
        [Required(ErrorMessage = "Se requiere character description"), StringLength(60,ErrorMessage = "Longitud Maxima 60")]
        public string characterDescription {get; set;}

        public Actor Actor {get; set;}
        public roleTypes roleTypes {get; set;}
        public filmTitles filmTitles {get; set;}

    }
}