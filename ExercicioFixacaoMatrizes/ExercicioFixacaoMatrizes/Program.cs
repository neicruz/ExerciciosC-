using System;

namespace ExercicioFixacaoMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, m];

            for (int i =0; i<n;i++)
            {
                string[] texto = Console.ReadLine().Split(' ');

                for (int j=0; j<m;j++)
                {
                    matriz[i, j] = int.Parse(texto[j]);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");
            for (int i=0; i<n;i++)
            {
                for (int j=0;j<m;j++)
                {
                    Console.Write(matriz[i,j]+" ");
                }
                Console.WriteLine("");
            }

            int valor = int.Parse(Console.ReadLine());

            int[,] v1 = new int[n, m];
            Console.WriteLine("TESTE AQUI");
            int cont1 = 0;
            //int cont2 = 0;

            for (int i=0; i<n;i++)
            {
                
                for (int j = 0; j < m; j++)
                {
                    
                    if (matriz[i,j]==valor)
                    {

                        Console.WriteLine("Position " + cont1 + "," + j);
                        int left = j - 1;
                        int right = j + 1;
                        int down = i + 1;
                        Console.WriteLine("Left: "+matriz[i,left]);
                        Console.WriteLine("Down: " + matriz[down, j]);
                        if (matriz[i,right])
                        {
                            Console.WriteLine("Right: " + matriz[i, right]);
                        }
                    }
                    

                }
                cont1++;
            }
           






            /*for (int i=0;i<n;i++)
            {
                for (int j = 0; j<m;j++)
                {
                    Console.WriteLine(v1[i,j]);
                }
            }*/
            

        }
    }
}
