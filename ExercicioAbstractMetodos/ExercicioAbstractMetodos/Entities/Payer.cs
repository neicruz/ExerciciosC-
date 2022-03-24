using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAbstractMetodos.Entities
{
    abstract class Payer
    {
        public string Name{ get; set; }
        public double AnualIncome{ get; set; }

        public Payer(string name, double anualincome)
        {
            Name = name;
            AnualIncome = anualincome;
        }

        public abstract double TotalTaxes();
    }
}
