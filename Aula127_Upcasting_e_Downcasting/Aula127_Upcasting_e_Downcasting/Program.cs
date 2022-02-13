using System;
using Aula127_Upcasting_e_Downcasting.Entities;

namespace Aula127_Upcasting_e_Downcasting
{
    class Program
    {
        static void Main(string[] args)
        {

            Account account = new Account(1001, "Alex", 0.0);

            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //UPCASTING

            Account acc = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingisAccount(1004, "Anna", 0.0, 0.01);

            //DOWNCASTING
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            if(acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if(acc3 is SavingisAccount)
            {
                //SavingisAccount acc5 = (SavingisAccount)acc3;
                SavingisAccount acc5 = acc3 as SavingisAccount;
                acc5.UpdateBalance();
                Console.WriteLine("UPDATE!");
            }
            

        }
    }
}