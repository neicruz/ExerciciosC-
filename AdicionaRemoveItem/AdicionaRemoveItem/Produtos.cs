using System;
using System.Globalization;

namespace AdicionaRemoveItem
{
    class Produtos
    {
        public string Nome;
        public double Preco;
        public int Quantidade;


        public Produtos()
        {

        }
        public Produtos(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public void AdicionaProduto(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }

        public double Total()
        {
            return Quantidade * Preco;
        }

        public void RemoveProduto(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }

        public override string ToString()
        {
            return "Dados atualizados: "
                + Nome 
                + ", " 
                + "$"
                +Preco.ToString("F2",CultureInfo.InvariantCulture)
                +", "
                +Quantidade
                +" Unidades"
                +" Total: "
                + Total().ToString("F2",CultureInfo.InvariantCulture); 
                
        }

    }
}
