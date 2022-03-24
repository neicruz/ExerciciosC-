using System;
using System.Globalization;

namespace ExercicioCalcRetangulo
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }
        public double Perimetro()
        {
            return Largura+Largura+Altura+Altura;
        }
        public double Diagonal()
        {
            return Math.Sqrt(Altura * Altura + Largura * Largura);
        }

        public override string ToString()
        {
            return "AREA² é igual a " +Area()+", Perimetro é de "+Perimetro()+" e Diagonal de "+Diagonal() ;
        }
    }
}
