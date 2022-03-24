using System;
using System.Globalization;
namespace SituacaoProblema1
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00,10);
            Console.WriteLine(p.Nome);
            p.Nome = "T";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);



        }
    }
}
