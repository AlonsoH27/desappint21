using System.ComponentModel.DataAnnotations;

namespace p20_blazorcrud.Data {
    public class Movie {
        [Key]
        public int Id {get; set;} 
        public string nameMovie {get; set;}
        public int year {get; set;}
        public string classification {get; set;}
        public string category {get; set;}
    }
}