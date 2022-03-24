using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacaoArquivos.Entities
{
    class Products
    {
        public string Name{ get; set; }
        public double Price{ get; set; }
        public int Quantity{ get; set; }

        public Products()
        {

        }
        public Products(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;

        }

        public double TotalPrice()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return Name
                +" "
                +Price
                +" "
                +Quantity;
        }
    }
}
