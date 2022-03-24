using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPropostoHerancaPoliformismo.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge{ get; set; }

        public OutsourcedEmployee()
        {

        }
        public OutsourcedEmployee(string name, int hours, double valueperhour, double addionalcharge) 
            : base(name, hours, valueperhour)
        {
            AdditionalCharge = addionalcharge;
        }

        public override double Payment()
        {
            
            return base.Payment()+1.1 * AdditionalCharge;
            
        }
    }
}
