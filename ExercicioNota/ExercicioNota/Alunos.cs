using System;
using System.Globalization;

namespace ExercicioNota
{
    class Alunos
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal()
        {
            return (Nota1 + Nota2 + Nota3);
        }
        public string Situacao()
        {
            if (NotaFinal() >= 60)
            {
                return "Aprovado";
            }
            else
            {
                return "Reprovado, faltou "+((60-NotaFinal()).ToString("F2",CultureInfo.InvariantCulture)+" Pontos");
            }
        }
        public override string ToString()
        {
            return "Sua nota final foi "
                +NotaFinal().ToString("F2",CultureInfo.InvariantCulture)
                +" Situação é "+Situacao();
        }


    }
}
