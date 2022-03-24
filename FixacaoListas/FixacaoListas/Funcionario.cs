using System;
using System.Globalization;

namespace FixacaoListas
{
    class Funcionario
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string Cargo { get; private set; }
        public double Salario { get; private set; }


        public Funcionario()
        {

        }
        public Funcionario(int id, string nome, string cargo, double salario)
        {
            Id = id;
            Nome = nome;
            Cargo = cargo;
            Salario = salario;
        }

        public void Aumento(double porcentagem)
        {
            Salario = Salario + (Salario*porcentagem/100);
        }
        public void AlterarCargo(string Novocargo)
        {
            Cargo = Novocargo;
        }

        public override string ToString()
        {
            return "Id :"
                +Id
                +" "
                +"Nome: "
                +Nome
                + " "
                + "Cargo: "
                +Cargo
                + " "
                + "Salario: "
                +Salario.ToString("F2",CultureInfo.InvariantCulture);
        }



    }
}
