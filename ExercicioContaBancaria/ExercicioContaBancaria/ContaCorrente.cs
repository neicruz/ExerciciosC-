using System;
using System.Globalization;

namespace ExercicioContaBancaria
{
    class ContaCorrente
    {
        public int Conta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public ContaCorrente()
        {
        }
        public ContaCorrente(int conta, string nome)
        {
            Conta = conta;
            Nome = nome;
            Saldo = 0;
        }
        public ContaCorrente (int conta, string nome,double deposito)
        {
            Conta = conta;
            Nome = nome;
            Depositar (deposito);

        }
        public void AlterarNome(string nome)
        {
            Nome = nome;
        }
        public void Depositar( double valor)
        {
            Saldo = Saldo + valor;
        }

        public void Sacar(double valor)
        {
            Saldo = Saldo - valor - 5;
        }

        public override string ToString()
        {
            return "Conta: "
                +Conta
                +", "
                +"Titular: "
                +Nome
                +" Saldo: "
                +Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}
