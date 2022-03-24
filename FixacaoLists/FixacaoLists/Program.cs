using System;

namespace FixacaoLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario(5538,"João",1000.00);
            func.Saldo = 1000.00;
        }
    }
}
