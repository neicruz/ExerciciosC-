using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace ExercicioPropostoHerancaPoliformismo.Entities
{
    class Employee
    {
        public string Name{ get; set; }
        public int Hours{ get; set; }
        public double ValuePerHour { get; set; }

        public Employee()
        {

        }
        public Employee(string name, int hours, double valueperhour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valueperhour;
        }

        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            //sb.AppendLine
            /*foreach (Employee varrer in )
            {

            }*/
            sb.Append(Name + " - " + Payment().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
            
        }


    }
}
