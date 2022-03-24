using System;
using System.Collections.Generic;
using System.Globalization;

namespace FixacaoLists
{
    class Funcionario
    {
        public int Conta { get; private set; }
        private string _nome;
        public double Saldo { get; private set; }

        public Funcionario()
        {

        }
        public Funcionario(int conta, string nome, double saldo)
        {
            Conta = conta;
            _nome = nome;
            Saldo = saldo;
        }
        

    }
}
