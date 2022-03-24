using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExercicioFixacaoListas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos empregados voce deseja registrar? ");
            int controle = int.Parse(Console.ReadLine());
            //Funcionario[] vetor = new Funcionario[controle];
            //int id;
            //string nome;
            //double salario;


            List<Funcionario> list = new List<Funcionario>() ;


            for (int i = 0;i<controle;i++)
            {
                Console.WriteLine("Id do Funcionario: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Nome do Funcionario: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Salario do Funcionario: ");
                double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                list.Add(new Funcionario(id, nome, salario));
                

            }

            foreach (Funcionario varrer in list)
            {
                Console.WriteLine(varrer);
            }
            Console.WriteLine();
            Console.WriteLine("Entre com o ID para alterar salario: ");
            int cont = int.Parse(Console.ReadLine());
            Funcionario receber = list.Find(x => x.Id == cont);
            if (receber ==null)
            {
                Console.WriteLine("Funcionario Não existe");
            }else if(receber.Id == cont)
            {
                Console.WriteLine(receber);
                Console.WriteLine("Digite o percentual de aumento: ");
                receber.Aumento(double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture));
            }

            
            /*else
            {
                Console.WriteLine("ID NÃO EXISTE!!!");
            }*/


            foreach (Funcionario varrer in list)
            {
                Console.WriteLine(varrer);
            }
            /*
            for (int i=0;i<vetor.Length;i++)
            {
                Console.WriteLine(vetor[i]);
            }

            Console.WriteLine("Entre com o ID para alterar salario: ");
            int cont = int.Parse(Console.ReadLine());
            for (int i=0;i<vetor.Length;i++)
            {
                vetor[i].   
            }*/

        }
    }
}
