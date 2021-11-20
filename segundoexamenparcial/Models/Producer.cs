using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace segundoexamenparcial.Modelo
{
    public class Producers {
        [Key]
        public int producerID {get; set;}
        public string producerName {get; set;}
        public string contactEmailAddress {get; set;}
        public string webSite {get; set;}

        public ICollection<filmTitlesProducers> filmTitlesProducers {get; set;}
    }
}