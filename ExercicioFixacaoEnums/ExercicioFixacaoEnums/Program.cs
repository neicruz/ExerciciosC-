using System;
using System.Collections.Generic;
using System.Globalization;
using ExercicioFixacaoEnums.Entities;
using ExercicioFixacaoEnums.Entities.Enums;

namespace ExercicioFixacaoEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("E-mail: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date: format(DD/MM/YYYY) ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name,email,birthdate);

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus os = Enum.Parse<OrderStatus>(Console.ReadLine());
            
            Console.Write("How many items to this order? ");
            int control = int.Parse(Console.ReadLine());
            Order order = new Order(DateTime.Now, os, client);
            int idex = 0;
            Console.WriteLine("");
            for (int i =0; i< control; i++)
            {
                idex = 1 + i; ; 
                Console.WriteLine("Enter #"+idex+" item data: ");
                Console.Write("Product name: ");
                string productname = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                
                Product product = new Product(productname,price );
                OrderItem orderItem = new OrderItem(quantity,price,product);
                
                order.AddItem(orderItem);
                Console.WriteLine("");
                

            }
            Console.WriteLine(order);


        }
    }
}
