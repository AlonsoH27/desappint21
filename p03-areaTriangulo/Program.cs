using System;

namespace p02_areaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            float b, al, a;
            b = al = a = 0;
            Console.WriteLine("Calculando el area de un triangulo\n");
            Console.WriteLine("Dame la base");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Dame la altura");
            al = float.Parse(Console.ReadLine());
            a = (b * al) / 2;
            Console.WriteLine($"El area del triangulo es de: {a}");


        }
    }
}
