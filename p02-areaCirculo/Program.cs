using System;

namespace p02_areaCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            float r=0;
            double a=0;
            Console.WriteLine("Calcula el area de un circulo");
            Console.WriteLine("Dame el radio");
            r = float.Parse(Console.ReadLine());
            a = Math.PI * Math.Pow(r,2);
            Console.WriteLine($"El area del circulo es de: {a}");
        }
    }
}
