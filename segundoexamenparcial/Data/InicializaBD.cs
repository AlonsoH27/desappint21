using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using segundoexamenparcial.Modelo;

namespace segundoexamenparcial.Data
{
    public class InicializaBD {
        public static void Inicializar(UniContexto contexto){
            contexto.Database.EnsureCreated();

            if(contexto.Actors.Any()){
                return; //la bd ya se encuentra con datos
            }
            //agregando actores.
            var actores = new Actor[]{
                new Actor {fullName="Leonardo Di Caprio", actorNotes=10},
                new Actor {fullName="Robert Dawny Jr", actorNotes=10},
                new Actor {fullName="Eugenio Derbez", actorNotes=10},
                new Actor {fullName="Jennifer Aniston", actorNotes=10},
                new Actor {fullName="Mark Rufalo", actorNotes=10},
            };
        }
    }
}