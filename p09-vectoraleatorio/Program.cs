using System;

namespace p09_vectoraleatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TAM=15;
            int [] A = new int [TAM];
            int [] B = new int [TAM];
            int [] C = new int [TAM];

            Random rnd = new Random();

            for(int i=0; i<A.Length; i++) {
                A[i] = rnd.Next(1,100);
                B[i] = rnd.Next(1,100);
                C[i] = A[i] + B[i];

            }
            Console.WriteLine("\n Elementos de A: \n"); imprime(A);
            Console.WriteLine("\n Elementos de B: \n"); imprime(B);
            Console.WriteLine("\n Elementos de C: \n"); imprime(C);

        }

        static void imprime(int[] v) {
            for(int i=0; i<v.Length; i++){
                Console.Write($"{v[i]} ");
            }
            Console.WriteLine();
        }
    }
}
