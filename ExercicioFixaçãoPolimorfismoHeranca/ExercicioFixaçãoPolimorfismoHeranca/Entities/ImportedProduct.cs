using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixaçãoPolimorfismoHeranca.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price,double customsFee):base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            return TotalPrice().ToString("F2",CultureInfo.InvariantCulture)+" (Customs Fee: $ "+CustomsFee.ToString("F2",CultureInfo.InvariantCulture)+")";
        }
        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}
