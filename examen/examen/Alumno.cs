using System.Collections.Generic;
using System;


namespace examen
{

     public class Alumno{
        public Alumno(string nombre, int edad, DateTime fechaing, string becado, int calif1, int calif2, int calif3){
            this.nombre = nombre;
            this.edad = edad;
            this.fechaing = fechaing;
            this.becado = becado;
            this.calif1 = calif1;
            this.calif2 = calif2;
            this.calif3 = calif3;

        }

        public string nombre {get; private set;}
        public int edad {get; private set;}
        public DateTime fechaing {get; private set;}
        public string becado {get; private set;}
        public int calif1 {get; private set;}
        public int calif2 {get; private set;}
        public int calif3 {get; private set;}
        
        
        public int Antiguedad {
            get{
                return DateTime.Now.Year - fechaing.Year;
            }
        }
        public int Calificaciones {
            get{
                int prom = (calif1+calif2+calif3)/3;
                return prom;
            }
        }
        public string Status{
            get{
                if (Calificaciones>6)
                {
                    return "Aprobado";
                }
                return "Reprobado";
            }

        }
        public int Becado{
            get{
                int bec =0;

                if (becado=="si")
                {
                    bec = bec +1;
                    return bec;
                }
                return bec;
            }
        }

        public override string ToString() =>
            $"Nombre: {nombre}, Edad: {edad}, FechaIng: {fechaing.ToString("dd/mm/yyyy")}, Becado: {becado},"+
            $" Califs: {calif1},{calif2},{calif3}, Antiguedad: {Antiguedad.ToString()}, Promedio: {Calificaciones}, Mensaje: {Status}";

     }  

}   