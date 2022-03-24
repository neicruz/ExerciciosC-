using System;

namespace exerciciostruct
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double? N = null;
            double? m = 10.0;

            Console.WriteLine(N.GetValueOrDefault());
            Console.WriteLine(m.GetValueOrDefault());

            Console.WriteLine(N.HasValue);
            Console.WriteLine(m.HasValue);

            if (N.HasValue)
            {
                Console.WriteLine(N.Value);
            }
            else
            {
                Console.WriteLine("N IS NULL");
            }
            if (m.HasValue)
            {
                Console.WriteLine(m.Value);
            
            }
            else
            {
                Console.WriteLine("m IS NULL");
            }



        }
    }
}
