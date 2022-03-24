using System;

namespace exercicioForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = new string[] { "Maria", "Bob", "Alex" };

            for (int i=0;i<vetor.Length;i++)
            {
                Console.WriteLine(vetor[i]);
            }

            Console.WriteLine("--------------------------------------");

            foreach (string percorre in vetor)
            {
                Console.WriteLine(percorre);
            }
        }
    }
}
