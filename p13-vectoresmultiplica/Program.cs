using System;

namespace p13_vectoresmultiplica
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TAM=20;
            int [] A = new int [TAM];
            int [] B = new int [TAM];
            int [] C = new int [TAM];
            int [] D = new int [TAM];
            Random rnd = new Random();

            for(int i=0; i<A.Length; i++){
                A[i] = rnd.Next(1,100);
                for(int j=0; j<B.Length; j++){
                    B[j] = rnd.Next(1,100);
                    D[19-j] = B[j]; 
                    C[i] = A[i]*D[j];
                }
                
            }
           
            Console.WriteLine("\n Valores de A "); imprime(A);
            Console.WriteLine("\n Valores de B "); imprime(B);
            Console.WriteLine("\n Valores invertidos de B "); imprime(D);
            Console.WriteLine("\n Valores de C "); imprime(C);

        }
        static void imprime(int[] v) {
            for(int i=0; i<v.Length; i++){
                Console.Write($"{v[i]} ");
            }
            Console.WriteLine();
        }
    }
}
