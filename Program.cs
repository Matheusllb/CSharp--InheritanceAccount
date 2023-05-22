using InheritanceAccount.Entities;
using System;

namespace InheritanceAccount
{
    public class Program
    {
        public static void Main()
        {
            Account acc = new Account(1234, "Marcos", 0.0);
            BusinessAccount bacc = new BusinessAccount(5678, "Geovana", 0.0, 500.00);

            // UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(9101, "Roberto", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1121, "Paula", 0.0, 0.01);

            // DOWNCASTING 

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            if(acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                //                    OU
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if(acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                //                   OU
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}
