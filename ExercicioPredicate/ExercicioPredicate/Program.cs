using System;
using ExercicioPredicate.Entities;
using System.Collections.Generic;

namespace ExercicioPredicate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> lista = new List<Product>();

            lista.Add(new Product("Tv",900.00));
            lista.Add(new Product("Mouse", 50.00));
            lista.Add(new Product("Tablet", 350.50));
            lista.Add(new Product("HD Case", 80.90));

        }
    }
}
