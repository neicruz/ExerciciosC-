using System;
using System.Globalization;

namespace ExercicioFixacaoListas
{
    class Funcionario
    {
        public int Id{ get; private set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }


        public Funcionario()
        {

        }
        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;

        }

        public void Aumento(double porcentagem)
        {
            Salario = (Salario * porcentagem / 100) + Salario;
        }

        public override string ToString()
        {
            return "Id:"
                +Id
                +" Nome:"
                +Nome
                +" Salario:"
                +Salario.ToString("F2",CultureInfo.InvariantCulture); 
        }



    }


}
