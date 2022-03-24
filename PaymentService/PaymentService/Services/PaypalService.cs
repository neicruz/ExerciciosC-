using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService.Services
{
    class PaypalService:IOnlinePaymentService
    {
        public double Interest(double amount, int months)
        {
            double resultado = amount * 1.01;
            return resultado;
        }
        public double PaymentFee(double amount)
        {
            return amount * 1.02;
        }

    }
}
