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
        
        public float salarioMayor{
            get{
                float m= (float)profesores[0].salario;
                foreach (var p in profesores)
                    if(p.salario>m) m =(float)p.salario;
                return m;
            }
        }
        public float salarioMenor{
            get{
                float m= (float)profesores[0].salario;
                foreach (var p in profesores)
                    if(p.salario<m) m =(float)p.salario;
                return m;
            }
        }

        public float totalSalario{
            get{
                float s=0;
                foreach (var p in profesores)
                {
                    s=(float)p.salario;
                    return s;
                }
                return s;
            }
        }

    }

}