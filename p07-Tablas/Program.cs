using System;

namespace p07_Tablas
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplicador, final;
            string linea, tope;
            Console.Write("¿Que tabla de multiplicar? :  ");
            linea = Console.ReadLine();
            Console.Write("¿Hasta que numero?: ");
            tope= Console.ReadLine();
            multiplicador = int.Parse(linea);
            final = int.Parse(tope);
            for(int i=1; i<=final; i++ ) {              
                    Console.Write(i+" x "+multiplicador+" = "+i*multiplicador+"\n");               
            }           
        }
    }
}
