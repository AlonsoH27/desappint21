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
                new Rol {Tipo = "Personaje principal"},
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
                new Pelicula {Titulo="Spiderman", Historia="Una araña lo pico", fechaEstreno=DateTime.Parse("1/1/2007"), 
                Duracion=128, GeneroId=generos.Single(g=>g.Descripcion=="Aventura").Id,
                CertificadoId=certificados.Single(c=>c.Descripcion=="U").Id},
                new Pelicula {Titulo="Batman", Historia="un murgielago", fechaEstreno=DateTime.Parse("1/1/1545"), 
                Duracion=128, GeneroId=generos.Single(g=>g.Descripcion=="Aventura").Id,
                CertificadoId=certificados.Single(c=>c.Descripcion=="12A").Id},
                new Pelicula {Titulo="Goku", Historia="Goku pelea", fechaEstreno=DateTime.Parse("27/09/2015"), 
                Duracion=128, GeneroId=generos.Single(g=>g.Descripcion=="Aventura").Id,
                CertificadoId=certificados.Single(c=>c.Descripcion=="U").Id},
            };
            foreach(Pelicula p in peliculas) contexto.Pelicula.Add(p);
            contexto.SaveChanges();


            //Agrega Pelicula Actor Rol
            var par =new PeliculaActorRol[]{
                new PeliculaActorRol {PeliculaId=peliculas.Single(p=>p.Titulo=="Goku").Id,
                ActorId=actores.Single(a=>a.Nombre=="Cantinflas").Id,
                RolId=roles.Single(r=>r.Tipo=="Extra").Id},
                new PeliculaActorRol {PeliculaId=peliculas.Single(p=>p.Titulo=="Spiderman").Id,
                ActorId=actores.Single(a=>a.Nombre=="Pedro infante").Id,
                RolId=roles.Single(r=>r.Tipo=="Cameo").Id},
                new PeliculaActorRol {PeliculaId=peliculas.Single(p=>p.Titulo=="Batman").Id,
                ActorId=actores.Single(a=>a.Nombre=="Cantinflas").Id,
                RolId=roles.Single(r=>r.Tipo=="Personaje principal").Id},
                new PeliculaActorRol {PeliculaId=peliculas.Single(p=>p.Titulo=="Macario").Id,
                ActorId=actores.Single(a=>a.Nombre=="Pedro infante").Id,
                RolId=roles.Single(r=>r.Tipo=="Personaje secundario").Id},
            };
            foreach(PeliculaActorRol pAl in par) contexto.PeliculaActorRol.Add(pAl);
            contexto.SaveChanges();


            //Agrega Pelicula Productor
            var pelpro = new PeliculaProductor[] {
                new PeliculaProductor {ProductorId=productores.Single(p=>p.Nombre=="Diego luna").Id, 
                PeliculaId=peliculas.Single(pel=>pel.Titulo=="Batman").Id},
                new PeliculaProductor {ProductorId=productores.Single(p=>p.Nombre=="Cuaron").Id, 
                PeliculaId=peliculas.Single(pel=>pel.Titulo=="Macario").Id},
                new PeliculaProductor {ProductorId=productores.Single(p=>p.Nombre=="Guillermo del Toro").Id, 
                PeliculaId=peliculas.Single(pel=>pel.Titulo=="Spiderman").Id},
                new PeliculaProductor {ProductorId=productores.Single(p=>p.Nombre=="Guillermo del Toro").Id, 
                PeliculaId=peliculas.Single(pel=>pel.Titulo=="Goku").Id},
            };
            foreach(PeliculaProductor pp in pelpro) contexto.PeliculaProductor.Add(pp);
            contexto.SaveChanges();


        }
    }
}