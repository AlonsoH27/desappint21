using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace segundoexamenparcial.Modelo
{
    public class filmTitles {
        [Key]
        public int filmTitleId {get; set;}
        [Required(ErrorMessage = "Se requiere film name"), StringLength(60,ErrorMessage = "Longitud Maxima 60")]
        public string filmTitleName {get; set;}
        [Required(ErrorMessage = "Se requiere film story"), StringLength(60,ErrorMessage = "Longitud Maxima 60")]
        public string filmStory {get; set;}
        [DataType(DataType.Date)]
        public DateTime filmReleaseDate {get; set;}
        public int filmDuraction {get; set;}
        public int filmGenreId {get; set;}
        public string filmCertificateId {get; set;}
        public string filmAdditionalInfo {get; set;}

        public filmGenres filmGenres {get; set;}
        public filmCertificates filmCertificates {get; set;}
        public ICollection<filmsActorRoles> filmsActoresRoles {get; set;}
        public ICollection<filmTitlesProducers> filmTitlesProducers {get; set;}

    }
}