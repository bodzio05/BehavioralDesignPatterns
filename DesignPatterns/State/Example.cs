using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public static class Example
    {
        public static void Execute_Example()
        {
            //Open a new account
            Account account = new Account("Konrad Kania");

            //Apply financial transactions
            account.Deposit(500.0);
            account.Deposit(300.0);
            account.Deposit(550.0);
            account.PayInterest();
            account.Withdraw(2000);
            account.Withdraw(1100);


            // Wait for user
            Console.ReadKey();
        }
    }
}
