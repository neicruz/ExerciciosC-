using System;
using System.Globalization;

namespace FixacaoStatic
{
    class Calculadora
    {
        public static double Pi = 3.14;

        public static double CalculaRaio(double rr)
        {
            return 2.0 * Pi * rr;
        }

        public static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }


    }
}
