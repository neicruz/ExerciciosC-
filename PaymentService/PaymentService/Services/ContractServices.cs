using System;
using PaymentService.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService.Services
{
    class ContractServices
    {
        private IOnlinePaymentService _taxService;

        public ContractServices(IOnlinePaymentService taxService)
        {
            _taxService = taxService;
        }

        public void ProcessContract (Contract contract, int month)
        {
            double parcelasemincremento = contract.TotalValue/month;

            double taxCal = _taxService.Interest(parcelasemincremento,month);        
        }
    }
}
