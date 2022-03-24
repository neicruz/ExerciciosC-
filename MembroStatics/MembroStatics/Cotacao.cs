using System;
using System.Globalization;

namespace MembroStatics
{
    class Cotacao
    {
        public static double CotacaoDia(double valorDolar, double QuantidadeDolar ) {
            return ((valorDolar * QuantidadeDolar)*1.06);
        }
        

    }
}
