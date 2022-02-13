using System;
using Aula128_Sobreposição_Palavras_virtual_Override_e_Base.Entities;

namespace Aula128_Sobreposição_Palavras_virtual_Override_e_Base
{
    class Program
    {
        static void Main(string[] args)
        {

            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingisAccount(1002, "Anna", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

        }
    }
}