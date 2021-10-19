using System;

namespace examen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creacion de la escuela
            Escuela miEscuela = new Escuela (" Universidad Patito SA de CV"," Ing. Juan Perez"," Av. De la Juventud 348");
            //Añadiendo profesores
            miEscuela.agregarProfesor(new Profesor("Jose Diaz",DateTime.Parse("01/01/2018"),"1A","Fisica",1200));
            miEscuela.agregarProfesor(new Profesor("Maria Perez",DateTime.Parse("10/02/2016"),"2A","Algebra",3400));
            miEscuela.agregarProfesor(new Profesor("Claudia Sid",DateTime.Parse("01/04/2019"),"4A","Calculo",3800));
            miEscuela.agregarProfesor(new Profesor("Carlos Lopez",DateTime.Parse("10/03/2016"),"8A","Quimica",1000));
            //Añadiendo alumnos
            miEscuela.profesores[0].agregarAlumno(new Alumno("Fatima Soto",23,DateTime.Parse("01/01/2019"),"Si",7,7,7));
            miEscuela.profesores[0].agregarAlumno(new Alumno("Damian Diaz",25,DateTime.Parse("01/01/2016"),"No",8,8,8));
            miEscuela.profesores[0].agregarAlumno(new Alumno("Fatima Soto",23,DateTime.Parse("01/01/2018"),"Si",6,6,6));

            miEscuela.profesores[1].agregarAlumno(new Alumno("Maria Ochoa",20,DateTime.Parse("01/10/2018"),"Si",9,9,9));
            miEscuela.profesores[1].agregarAlumno(new Alumno("Fatima Soto",23,DateTime.Parse("01/01/2019"),"Si",7,7,7));

            miEscuela.profesores[3].agregarAlumno(new Alumno("Jose Ochoa",19,DateTime.Parse("01/10/2016"),"No",6,6,6));

            Console.WriteLine("\n>>> Datos generales de la Escuela: \n");

            Console.WriteLine("Nombre:"+miEscuela.nombre);
            Console.WriteLine("Encargado:"+ miEscuela.encargado);
            Console.WriteLine("Domicilio:"+ miEscuela.domicilio);

            Console.WriteLine($"\nTotal profesores: {miEscuela.profesores.Count}");
            Console.WriteLine($"Total alumnos: " );
            Console.WriteLine($"Total alumnos becados: ");
            Console.WriteLine($"Total salario profesores:{miEscuela.totalSalario}");

            Console.WriteLine("\n>>> Datos generales de los profesores: \n");

            foreach (Profesor p in miEscuela.profesores)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine($"\nMayor promedio:");
            Console.WriteLine($"Menor promedio:");
            Console.WriteLine($"Total becados:");

            Console.WriteLine("\n>>> Alumnos por profesor: \n");
            Console.WriteLine($"\n> Nombre: {miEscuela.profesores[0].nombre}, Grupo: {miEscuela.profesores[0].grupo}\n");

            foreach (Alumno a in miEscuela.profesores[0].alumnos)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine($"\nMayor promedio:");
            Console.WriteLine($"Menor promedio:");
            Console.WriteLine($"Total becados:");

            Console.WriteLine($"\n> Nombre: {miEscuela.profesores[1].nombre}, Grupo: {miEscuela.profesores[1].grupo}\n");

            foreach (Alumno a in miEscuela.profesores[1].alumnos)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine($"\nMayor promedio:");
            Console.WriteLine($"Menor promedio:");
            Console.WriteLine($"Total becados:");

            Console.WriteLine($"\n> Nombre: {miEscuela.profesores[2].nombre}, Grupo: {miEscuela.profesores[2].grupo}\n");

            foreach (Alumno a in miEscuela.profesores[2].alumnos)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine($"\nMayor promedio:");
            Console.WriteLine($"Menor promedio:");
            Console.WriteLine($"Total becados:");

            Console.WriteLine($"\n> Nombre: {miEscuela.profesores[3].nombre}, Grupo: {miEscuela.profesores[3].grupo}\n");

            foreach (Alumno a in miEscuela.profesores[3].alumnos)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine($"\nMayor promedio:");
            Console.WriteLine($"Menor promedio:");
            Console.WriteLine($"Total becados:");


        }
    }
}
