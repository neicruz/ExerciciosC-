using System;
using PaymentService.Entities;
using PaymentService.Services;
using System.Globalization;
using System.Collections.Generic;

namespace PaymentService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data: ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/mm/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract Value: ");
            double contractValue = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int inst= int.Parse(Console.ReadLine());
            Contract contract = new Contract(number, date, contractValue);


            double parcela1 = contractValue / inst;
            
            List <Installment> lista = new List<Installment>();

            int control = 1;
            for (int i = 0; i <inst;i++)
            {
                DateTime date2 = date.AddMonths(control);
                double parcela2 = 

                lista.Add();
                control++;

            }

        }
    }
}
