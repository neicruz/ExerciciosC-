using System;

namespace exercicioModificadores
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum(2, 3 );
            Console.WriteLine(s1);
            int s2 = Calculator.Sum(2, 5, 2 );
            Console.WriteLine(s2);
        }
    }
}
