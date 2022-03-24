using System;

namespace ExercicioModificadorRefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);

            int x = 15;
            int y;
            Calculator.TripleOut(x, out y);
            Console.WriteLine(y);
        }
    }
}
