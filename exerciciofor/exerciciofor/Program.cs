using System;

namespace exerciciofor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um Valor para ir até: ");
            int n1 = int.Parse(Console.ReadLine());
            int contar1 = 0;
            int contar2 = 0;
            for (int i=0;i<=n1;i++)
            {
                if(i>=10 || i<=20)
                {
                    contar1++;
                    
                }
                
                
                contar2++;
                   
                
                
            }
            Console.WriteLine("In são {0} e out são {1}", contar1, contar2);
        }
    }
}
