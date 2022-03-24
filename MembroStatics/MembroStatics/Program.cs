using System;
using System.Globalization;

namespace MembroStatics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a cotação do dolar? ");
            double cotacao = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade a comprar? ");
            double quantidade = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago é de " + Cotacao.CotacaoDia(cotacao,quantidade));
        }
    }
}
