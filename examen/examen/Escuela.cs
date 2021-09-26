using System.Collections.Generic;

namespace examen
{
    
    public class Escuela {
        public Escuela(string nombre, string encargado, string domicilio){
            this.nombre=nombre;
            this.encargado=encargado;
            this.domicilio=domicilio;

            profesores = new List<Profesor>();
        }

        public string nombre {get; private set;}
        public string encargado {get; private set;}
        public string domicilio {get; private set;}

        public List<Profesor> profesores {get; private set;}
        public void agregarProfesor(Profesor profesor){
            profesores.Add(profesor);
        }
        

    }

}