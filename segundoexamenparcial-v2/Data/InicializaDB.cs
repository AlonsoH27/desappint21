using segundoexamenparcial_v2.Modelo;
using System.Linq;
using System;

namespace segundoexamenparcial_v2.Data
{
    public class InicializaDB {
        public static void Inizializar(DvdContexto contexto) {
            contexto.Database.EnsureCreated();
            if(contexto.Pelicula.Any()) {
                return;
            }

            //Agregar Actores
            var actores = new Actor [] {
                new Actor{ Nombre = "Pedro infante"},
                new Actor{ Nombre = "Cantinflas"},
                new Actor{ Nombre = "Jorge Negrete"},
                new Actor{ Nombre = "Dolores del Rio"},
            };
            foreach (Actor a in actores) contexto.Actores.Add(a);
            contexto.SaveChanges();

            //Agrega Roles
            var roles = new Rol [] {
                new Rol {Tipo = "Personaje principla"},
                new Rol {Tipo = "Personaje secundario"},
                new Rol {Tipo = "Cameo"},
                new Rol {Tipo = "Extra"},
            };
            foreach (Rol r in roles) contexto.Roles.Add(r);
            contexto.SaveChanges();
            
            //Agrega Generos
            var generos = new Genero[] {
                new Genero {Descripcion="Accion"},
                new Genero {Descripcion="Aventura"},
                new Genero {Descripcion="Comedia"},
                new Genero {Descripcion="Terror"},
            };
            foreach(Genero g in generos) contexto.Generos.Add(g);
            contexto.SaveChanges();

            //Agrega Certificados
            var certificados = new Certificado[] {
                new Certificado {Descripcion = "U"},
                new Certificado {Descripcion = "PG"},
                new Certificado {Descripcion = "12A"},
                new Certificado {Descripcion = "+18"},
            };
            foreach(Certificado c in certificados) contexto.Certificados.Add(c);
            contexto.SaveChanges();

            //Agrega Productor
            var productores = new Productor[] {
                new Productor {Nombre="Cuaron", Correo ="cuaron@gmail.com", sitioWeb="http://www.cuaron.com"},
                new Productor {Nombre="Guillermo del Toro", Correo ="toro@gmail.com", sitioWeb="http://www.deltoro.com"},
                new Productor {Nombre="Diego luna", Correo ="luna@gmail.com", sitioWeb="http://www.luna.com"},
            };
            foreach(Productor p in productores) contexto.Productores.Add(p);
            contexto.SaveChanges();

            //Agrega Peliculas
            var peliculas = new Pelicula[] {
                new Pelicula {Titulo="Macario", Historia="Ahi macario es el chido", fechaEstreno=DateTime.Parse("1/1/1945"), 
                Duracion=128, GeneroId=generos.Single(g=>g.Descripcion=="Aventura").Id,
                CertificadoId=certificados.Single(c=>c.Descripcion=="U").Id},
            };
            foreach(Pelicula p in peliculas) contexto.Pelicula.Add(p);
            contexto.SaveChanges();


            //Agrega Pelicula Actor Rol

            //Agrega Pelicula Productor
            //var pelpro = new PeliculaProductor[] {
                //new PeliculaProductor {ProductorId=productores.Single(p=>p.Id=true), PeliculaId=peliculas.Single(pel=>pel.Titulo=="Macario")},
            //};



        }
    }
}