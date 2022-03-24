using System;

namespace Demo_Test
{
    class Program
    {
        static void Main(string[] args)
        {





            
            DateTime date = DateTime.Now;
            int i = 1;
            DateTime date2= date.AddMonths(i);
            Console.WriteLine(date2);













            /*Console.WriteLine("Digite uma data: ");
            DateTime d1 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Digite outra data: ");
            DateTime d2 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("VALOR POR HORA");
            double valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("VALOR POR DIA");
            double valor2 = double.Parse(Console.ReadLine());


            TimeSpan t1 = d2.Subtract(d1);

            double n1 = (double)t1.TotalHours;

            if (n1>10 && n1<12)
            {
                Console.WriteLine("TAXA BASICA");
            }else if (n1>=12&&n1<24)
            {
                Console.WriteLine("TAXA DE UMA DIARIA");
            }
            else
            {
                if (n1%24!=0)
                {
                    double dia = Math.Round(n1/24);
                    double resultado = (dia * valor2 + 130) * 1.15;
                    Console.WriteLine(resultado);
                }
            }*/



        }
    }
}