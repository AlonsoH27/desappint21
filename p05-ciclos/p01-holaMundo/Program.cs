using System;

namespace p01_holaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            DateTime fecha = DateTime.Now;
            Console.WriteLine("¡Hola Mundo! \n");
            Console.WriteLine("Dame tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine($"\n{nombre} bienvenido al c#");
            Console.WriteLine($"Hoy es: {fecha:d} y son las {fecha:t}");
            Console.WriteLine($"\nHasta pronto");

        }
    }
}
