using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAbstractMetodos.Entities
{
    class Company : Payer
    {
        public int NumberEmployee { get; set; }

        public Company(string name,double anualincome,int numberemployee) : base(name,anualincome)
        {
            NumberEmployee = numberemployee;
        }
        public override double TotalTaxes()
        {
            double sum = 0;
            if (NumberEmployee>10)
            {
                sum = AnualIncome * 0.14;
            }
            else
            {
                sum = AnualIncome * 0.16;
            }
            return sum;
        }
    }
}
