using System;
using System.Collections.Generic;
using System.Globalization;
using ExercicioFixaçãoPolimorfismoHeranca.Entities;

namespace ExercicioFixaçãoPolimorfismoHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> lista = new List<Product>();

            int count = 1;

            for (int i = 0; i < n; i++)
            {
                
                Console.WriteLine("Product #"+count+" data:");
                Console.Write("Commom, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if (type =='i')
                {
                    Console.Write("Customs fee: ");
                    double customs = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    lista.Add(new ImportedProduct(name,price,customs));
                }else if (type == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    lista.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    lista.Add(new Product(name, price));
                }
                count++;
            }

            Console.WriteLine("PRICE TAGS:");
            foreach (Product varrer in lista)
            {
                Console.WriteLine(varrer.Name+ " $ "+varrer.PriceTag());
            }
        }
    }
}
