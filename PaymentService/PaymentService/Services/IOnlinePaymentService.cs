﻿namespace PaymentService.Services
{
    interface IOnlinePaymentService
    {
        double Interest(double amount, int months);



        double PaymentFee(double amount);
        
            
    }
}
