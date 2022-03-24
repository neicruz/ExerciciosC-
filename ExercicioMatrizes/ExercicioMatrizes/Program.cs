using System;

namespace ExercicioMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*double[,] matriz = new double[2, 3];

            Console.WriteLine(matriz.Length);//total de elementos

            Console.WriteLine(matriz.Rank);//total de linhas

            Console.WriteLine(matriz.GetLength(1));//total de dimensão da matriz setada*/

            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n,n];

            

            for (int i = 0; i<3; i++)
            {
                string[] ordenacao = Console.ReadLine().Split(' ');

                for (int j=0;j<n;j++)
                {
                    matriz[i, j] = int.Parse(ordenacao[j]);
                }
            }
            Console.WriteLine("Main Diagonal: ");
            for (int i =0; i<n;i++)
            {
                Console.Write(matriz[i,i]+" ");
            }

            Console.WriteLine("");

            int cont = 0;
            for (int i=0;i<n;i++)
            {
                for (int j=0;j<n;j++)
                {
                    if (matriz[i,j]<0)
                    {
                        cont++;
                    }
                }
            }
            Console.WriteLine("Negative numbers "+cont);
        }
    }
}
