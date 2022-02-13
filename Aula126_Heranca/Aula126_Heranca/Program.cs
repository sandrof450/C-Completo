using System;
using Aula126_Heranca.Entities;

namespace Aula126_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {

            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.00, 500.00);

            Console.WriteLine(account.Balance);
           // account.Balance = 200;

        }
    }
}