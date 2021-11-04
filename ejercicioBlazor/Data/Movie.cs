using System.ComponentModel.DataAnnotations;

namespace ejercicioBlazor.Data
{
    public class Movie {
        [Key]
        public int Id {get; set;}
        public string nameMovie {get; set;}
        public int year {get; set;}
        public string gender {get; set;}
        public string classification {get; set;}

    }
}