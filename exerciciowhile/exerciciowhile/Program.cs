using System;

namespace exerciciowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = 2002;
            Console.WriteLine("Digite sua senha valida: ");
            int valorDigitado = int.Parse(Console.ReadLine());

            if (senha!=valorDigitado) {
                while (senha != valorDigitado)
                {
                    Console.WriteLine("SENHA INCORRETA... TENTE NOVAMENTE...");
                    valorDigitado = int.Parse(Console.ReadLine());
                }
            }
            
            
            Console.WriteLine("Senha Correta");
            
        }
    }
}
