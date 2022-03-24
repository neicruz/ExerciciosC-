using System;
using System.Collections.Generic;
using System.Globalization;

namespace PaymentService.Entities
{
    class Contract
    {
        public int IdContract{ get; set; }
        public DateTime DateInit{ get; private set; }
        public double TotalValue{ get; set; }
        public Installment Installment { get; set; }

        public Contract(int idContract, DateTime dateInit, double totalValue)
        {
            IdContract = idContract;
            DateInit = dateInit;
            TotalValue = totalValue;
        }
        public override string ToString()
        {
            return "INSTALLMENTS"
                +"\n"
                +Installment.DueDate
                +" - "
                +Installment.Amount;
        }
    }
}
