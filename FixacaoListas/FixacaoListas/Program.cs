using System;
using System.Globalization;
using System.Collections.Generic;

namespace FixacaoListas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos funcionarios deseja cadastrar? ");
            int controle = int.Parse(Console.ReadLine());

            List<Funcionario> lista = new List<Funcionario>();

            for (int i=0; i<controle;i++)
            {
                Console.WriteLine("Entre com o ID unico do funcionario: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Nome do Funcionario: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Cargo do Funcionario: ");
                string Cargo = Console.ReadLine();
                Console.WriteLine("Salario do Funcionario: ");
                double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                lista.Add(new Funcionario(id,nome,Cargo,salario));
            }
            foreach (Funcionario varrer in lista)
            {
                Console.WriteLine(varrer);
            }
            Console.WriteLine("Digite o ID que deseja alterar salario: ");
            int idcont = int.Parse(Console.ReadLine());
            Funcionario receber = lista.Find(x=>x.Id==idcont);
            if (receber == null)
            {
                Console.WriteLine("FUNCIONARIO NÃO EXISTE!!!");
            }else if (receber.Id == idcont)
            {
                Console.WriteLine("Digite a porcentagem do aumento: ");
                receber.Aumento(double.Parse (Console.ReadLine(),CultureInfo.InvariantCulture));
            }
            foreach (Funcionario varrer in lista)
            {
                Console.WriteLine(varrer);
            }

        }
    }
}
