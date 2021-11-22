using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace segundoexamenparcial.Modelo
{
    public class filmCertificates {
        [Key]
        public int filmCertificateId {get; set;}
        public string Certificate {get; set;}

        public ICollection<filmTitles> filmTitles {get; set;}

    }
}