using System;
using System.ComponentModel.DataAnnotations;

namespace segundoexamenparcial.Modelo
{
    public class filmTitlesProducers {
        [Key]
        public int titleProducerId {get; set;}
        public int producerID {get; set;}
        public int filmTitleId {get; set;}

        public filmTitles filmTitles {get; set;}
        public Producer Producer {get; set;}
    }
}