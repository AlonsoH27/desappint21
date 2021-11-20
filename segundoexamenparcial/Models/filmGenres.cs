using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace segundoexamenparcial.Modelo
{   
    public class filmGenres {
        [Key]
        public int filmGenresID {get; set;}
        public string Genre {get; set;}

        public ICollection<filmTitles> filmTitles {get; set;}

    }
}