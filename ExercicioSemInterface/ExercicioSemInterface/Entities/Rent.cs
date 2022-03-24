using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioSemInterface.Entities
{
    class Rent
    {
        public string NameModel{ get; set; }
        public DateTime PickRent{ get; set; }
        public DateTime ReturnRent { get; set; }
        public double PricePerHour  { get; set; }
        public double PricePerDay { get; set; }

        public Rent()
        {

        }

        public Rent(string nameModel, DateTime pickRent, DateTime returnRent, double pricePerHour)
        {
            NameModel = nameModel;
            PickRent = pickRent;
            ReturnRent = returnRent;
            PricePerHour = pricePerHour;
        }

        public Rent(string nameModel, DateTime pickRent, DateTime returnRent, double pricePerHour, double pricePerDay) : this(nameModel, pickRent, returnRent, pricePerHour)
        {
            PricePerDay = pricePerDay;
        }

        public double TotalPayment()
        {
            DateTime d1 = PickRent;
            DateTime d2 = ReturnRent;

            TimeSpan t = d2.Subtract(d1);
            double inteiro =(double)t.TotalHours;
           
            if (inteiro > 10 && inteiro < 24)
            {
                double diaria = Math.Round(inteiro);
                if (inteiro > 12 && inteiro < 24) {

                    diaria = PricePerDay * 1.15;
                    return diaria;
                }
                else
                {
                    diaria = PricePerHour * inteiro*1.20;
                    return diaria;
                }
            }
            
            else if(inteiro>=24)
            {
                double diaria = 0;
                if (inteiro % 24 != 0)
                {
                    double dia = Math.Ceiling(inteiro / 24);
                    diaria = (dia * PricePerDay ) * 1.15;
                    
                }
                return diaria;
            }
            else
            {
                return Math.Ceiling(inteiro) * 10 * 1.20;
            }

        }
        public double Tax()
        {
            DateTime d1 = PickRent;
            DateTime d2 = ReturnRent;

            TimeSpan t = d2.Subtract(d1);
            double inteiro = (double)t.TotalHours;

            if (inteiro > 10 && inteiro < 24)
            {
                double diaria = Math.Ceiling(inteiro);
                if (inteiro > 12 && inteiro < 24)
                {

                    diaria = PricePerDay * 0.15;
                    return diaria;
                }
                else
                {
                    diaria = PricePerHour * inteiro * 0.20;
                    return diaria;
                }


            }
            else if (inteiro >= 24)
            {
                double diaria = 0;
                if (inteiro % 24 != 0)
                {
                    double dia = Math.Ceiling(inteiro / 24);
                    diaria = (dia * PricePerDay) * 0.15;

                }
                return diaria;
            }
            else
            {
                return Math.Ceiling(inteiro) * 10 * 0.20;
            }
        }
        public double BasePayment()
        {
            return TotalPayment() - Tax();
            
        }

        public override string ToString()
        {
            StringBuilder sw = new StringBuilder();
            sw.AppendLine("INVOICE");
            sw.AppendLine("Base Payment: "+ BasePayment().ToString("F2", CultureInfo.InvariantCulture));
            sw.AppendLine("Tax: "+ Tax().ToString("F2", CultureInfo.InvariantCulture));
            sw.AppendLine("Total Payment: "+ TotalPayment().ToString("F2", CultureInfo.InvariantCulture));

            return sw.ToString();
                        
        }
    }
}
