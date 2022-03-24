using System;
using System.Globalization;

namespace exercicio2Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Produto[] vetor = new Produto[n];

            for (int i=0; i <n;i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                vetor[i] = new Produto (nome,preco);
            }
            double soma = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                soma = soma + vetor[i].Preco;
            }
            double media = soma / vetor.Length;
            Console.WriteLine(media.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
