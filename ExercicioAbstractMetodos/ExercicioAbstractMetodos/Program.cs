using System;
using System.Collections.Generic;
using ExercicioAbstractMetodos.Entities;
using System.Globalization;

namespace ExercicioAbstractMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            List<Payer> lista = new List<Payer>();

            for (int i=0; i<n;i++)
            {
                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double income = double.Parse(Console.ReadLine().ToString(), CultureInfo.InvariantCulture);
                if (type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double expends = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new Individual(name, income,expends));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    lista.Add(new Company(name, income, employees));
                }
            }

            Console.WriteLine("");
            Console.WriteLine("TAXES PAID:");
            foreach (Payer varrer in lista)
            {
                Console.WriteLine(varrer.Name+": $"+varrer.TotalTaxes().ToString("F2",CultureInfo.InvariantCulture));

            }
            double sum = 0;
            foreach (Payer varrer in lista)
            {
                sum += varrer.TotalTaxes();
            }
            Console.WriteLine("TOTAL TAXES: $"+sum);
           
        }
    }
}
