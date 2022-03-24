using System;
using System.Globalization;
using System.Collections.Generic;
using ExercicioFixacaoMetodosAbstract.Entities;
using ExercicioFixacaoMetodosAbstract.Entities.Enums;

namespace ExercicioFixacaoMetodosAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());
            List<Shape> lista = new List<Shape>();
            for (int i = 0; i<n;i++)
            {
                Console.Write("Rectangle or Circle (r/c)? ");
                char type = char.Parse(Console.ReadLine()) ;
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (type=='r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new Rectangle(width,height,color ));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    lista.Add(new Circle(radius, color));
                }

            }
            Console.WriteLine("");

            Console.WriteLine("SHAPE AREAS:");
            foreach (Shape varrer in lista)
            {
                Console.WriteLine(varrer.Area().ToString("F2",CultureInfo.InvariantCulture));
            }
        }
    }
}
