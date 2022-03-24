using System;
using System.Globalization;
using System.Collections.Generic;
using ExercicioPropostoHerancaPoliformismo.Entities;

namespace ExercicioPropostoHerancaPoliformismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int number = int.Parse(Console.ReadLine());
            List<Employee> lista = new List<Employee>();

            for (int i = 0; i< number; i++)
            {
                Console.Write("Outsourced (y/n)? ");
                char tp = char.Parse(Console.ReadLine());

                if (tp == 'y')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double ValueHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Additional charge: ");
                    double AdditionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Employee employee = new OutsourcedEmployee( name, hours, ValueHour, AdditionalCharge);
                    lista.Add(employee);

                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double ValueHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Employee employee = new Employee(name, hours, ValueHour);
                    lista.Add(employee);
                }

            }
            Console.WriteLine("PAYMENTS");
            foreach (Employee varrer in lista) {
                Console.WriteLine(varrer.Name+" - "+"$ "+varrer.Payment().ToString("F2",CultureInfo.InvariantCulture));                             
            }

        }
    }
}
