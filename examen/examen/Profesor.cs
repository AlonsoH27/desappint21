using System.Collections.Generic;
using System;

namespace examen
{

    public class Profesor{
        public Profesor(string nombre, DateTime fechaing,string grupo, string materia, double salario){
            this.nombre = nombre;
            this.fechaing = fechaing;
            this.grupo = grupo;
            this.materia = materia;
            this.salario = salario;
            
            alumnos = new List<Alumno>();
        }

        public string nombre {get; private set;}
        public DateTime fechaing {get; private set;}
        public string grupo {get; private set;}
        public string materia {get; private set;}
        public double salario {get; private set;}

        public List<Alumno> alumnos {get; private set;}
        public void agregarAlumno(Alumno alumno){
            alumnos.Add(alumno);
        }
        public int Antiguedad {
            get{
                return DateTime.Now.Year - fechaing.Year;
            }
        }

        
        public override string ToString() =>
            $"Nombre:{nombre}, FechaIng: {fechaing.ToString("dd/mm/yyyy")}, Grupo: {grupo}, Materia: {materia}, Salario: {salario}, " +
            $"Alumnos: {alumnos.Count}, Antiguedad: {Antiguedad.ToString()}";

    }

}