using System.ComponentModel.DataAnnotations;

namespace segundoexamenparcial_v2.Modelo
{
    public class PeliculaActorRol {
        [Key]
        public int Id {get; set;}
        public int PeliculaId {get; set;}
        public int ActorId {get; set;}
        public int RolId {get; set;}
        public string Personaje {get; set;}
        public string Descripcion {get; set;}

        public Actor Actor{get; set;}
        public Rol Rol {get; set;}
        public Pelicula Pelicula {get; set;}

    }
}