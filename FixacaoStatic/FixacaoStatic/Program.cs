using System;
using System.Globalization;

namespace FixacaoStatic
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("Valor do Raio");
            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double circ = Calculadora.CalculaRaio(raio);
            double vol = Calculadora.Volume(raio);

            Console.WriteLine("Valor da Circunferencia é de "+circ.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Valor do Volume é de " + vol.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI é "+Calculadora.Pi);
        }


    }
}
