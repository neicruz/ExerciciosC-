using System;
using System.Globalization;

namespace ExercicioFuncionarioObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            

            Console.WriteLine("Dados do Funcionario: ");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            f1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto a descontar: ");
            f1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(f1);
            Console.WriteLine();
            Console.WriteLine("Digite a porcentagem de aumento do salario: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f1.AumentarSalario(porcentagem);
            Console.WriteLine(f1);
        }
    }
}
