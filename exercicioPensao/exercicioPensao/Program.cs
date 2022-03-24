using System;

namespace exercicioPensao
{
    class Program
    {
        static void Main(string[] args)
        {
            int quartoVazio = 10;
            Console.WriteLine("Quantos quartos deseja alugar? ");
            int n = int.Parse(Console.ReadLine());
            Dados[] vetor = new Dados [quartoVazio];

            for (int i = 1; i<=n; i++)
            {
                Console.WriteLine("Digite o Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o email: ");
                string email= Console.ReadLine();
                Console.WriteLine("Digite o quarto desejado: ");
                int quarto = int.Parse(Console.ReadLine());

                vetor[quarto] = new Dados(nome, email);
            }

            Console.WriteLine("Quartos Ocupados: ");
            for(int i = 0; i <10;i++)
            {
                if (vetor[i] != null)
                {
                    Console.WriteLine(i+":"+vetor[i]);
                }
            }
        }
    }
}
