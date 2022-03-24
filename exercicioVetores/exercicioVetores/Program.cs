using System;
using System.Globalization;

namespace exercicioVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int valor = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double[] vetor = new double[valor];
            double altura;

            for (int i = 0;i<valor;i++)
            {
                altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vetor[i]=altura;
            }

            double soma = 0;
            for (int i =0; i<vetor.Length;i++)
            {
                soma = soma + vetor[i];
            }
            double media = soma / vetor.Length;
            Console.WriteLine(media.ToString("F2",CultureInfo.InvariantCulture)+" Media de altura ");


        }
    }
}
