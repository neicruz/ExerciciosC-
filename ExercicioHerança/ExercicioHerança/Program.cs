using System;
using System.Globalization;
using System.Collections.Generic;
using ExercicioHerança.Entities;

namespace ExercicioHerança
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Account> lista = new List<Account>();

            lista.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            lista.Add(new BusinessAccount(1002,"Maria",500.0,400.00));
            lista.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            lista.Add(new BusinessAccount(1004,"Anna",500.0,500.0));

            double total = 0;
            foreach (Account varrer in lista)
            {
                total += varrer.Balance;
            }
            Console.WriteLine(total.ToString("F2",CultureInfo.InvariantCulture));

            foreach (Account varrer in lista)
            {
                varrer.Withdraw(10.0);
            }
            foreach(Account varrer in lista)
            {
                Console.WriteLine(varrer.Balance.ToString("F2", CultureInfo.InvariantCulture)) ;
            }























            
            /* 
            Account acc1 = new Account(1001, "Alex", 500.00);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.00, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
            Account account = new Account(1001,"Alex",0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //UPCASTING

            Account account1 = bacc;
            Account account2 = new BusinessAccount(1003, "Bob Marley", 0.0, 200.00);
            Account account3 = new SavingsAccount(1004,"Anna",0.0,0.01);

            //DOWNCASTING

            BusinessAccount account4 = (BusinessAccount)account2;
            account4.Loan(100.00);

            //BusinessAccount account5 = (BusinessAccount)account3;
            if (account3 is BusinessAccount)
            {
                //BusinessAccount account5 = (BusinessAccount)account3;
                BusinessAccount account5 = account3 as BusinessAccount;
                account5.Loan(200.00);
                Console.WriteLine("Loan!");
            }

            if(account3 is SavingsAccount)
            {
                //SavingsAccount account5 = (SavingsAccount)account3;
                SavingsAccount account5 = account3 as SavingsAccount;
                account5.UpdateBalance();
                Console.WriteLine("Update!");
            }*/

        }
    }
}
