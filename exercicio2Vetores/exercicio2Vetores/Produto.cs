using System;
using System.Globalization;

namespace exercicio2Vetores
{
    class Produto
    {
        public string Nome{ get; set; }
        public double Preco{ get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}
