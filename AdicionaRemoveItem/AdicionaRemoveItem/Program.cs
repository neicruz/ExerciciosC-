using System;
using System.Globalization;

namespace AdicionaRemoveItem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os dados do produto: ");
            Console.Write("Descricao: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o Preco: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());
            Produtos prd = new Produtos(nome,preco,quantidade);
            Console.WriteLine(prd);

            Console.WriteLine("Quantidade a adicionar: ");
            quantidade = int.Parse(Console.ReadLine());
            prd.AdicionaProduto(quantidade);
            Console.WriteLine(prd);

            Console.WriteLine("Quantidade a remover: ");
            quantidade = int.Parse(Console.ReadLine());
            prd.RemoveProduto(quantidade);
            Console.WriteLine(prd);
        }
    }
}
