using System;
using System.Globalization;

namespace exercicioFixacao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario a, b;
            a = new Funcionario();
            b = new Funcionario();

            Console.WriteLine("Digite o nome e salario do funcionario 1:");
            a.Nome = Console.ReadLine();
            a.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o nome e salario do funcionario 1:");
            b.Nome = Console.ReadLine();
            b.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double salarioMedio = (a.salario + b.salario) / 2;

            Console.WriteLine("O salario medio de {0} e {1} é {2}",a.Nome,b.Nome,salarioMedio.ToString("F2"));
        }
    }
}
