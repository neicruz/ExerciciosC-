using System;
using System.Globalization;

namespace ExercicioCalcRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Retangulo r= new Retangulo();
            


            Console.WriteLine("Entre com a Largura e Altura do Retangulo: ");
            Console.Write("Largura: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.Write("Altura: ");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(r);


        }
    }
}
