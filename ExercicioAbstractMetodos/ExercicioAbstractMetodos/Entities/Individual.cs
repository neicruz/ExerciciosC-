using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAbstractMetodos.Entities
{
    class Individual :Payer
    {
        public double HealthExpenditures{ get; set; }

        public Individual(string name, double anualincome,double helthexpenditures):base(name, anualincome)
        {
            HealthExpenditures = helthexpenditures;
        }

        public override double TotalTaxes()
        {
            double sum = 0;
            if (AnualIncome < 20000)
            {
                sum= (AnualIncome * 0.15) - (HealthExpenditures * 0.50);

            }
            else
            {
                sum = (AnualIncome * 0.25) - (HealthExpenditures * 0.50);
            }
            return sum;
        }
    }
}
