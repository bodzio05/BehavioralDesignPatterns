﻿using System.Collections.Generic;
using System.Linq;
using static System.Console;

// todo: fix namespace
namespace DesignPatterns.Commands
{
    public static class Example
    {
        public static void Execute_Example()
        {
            var ba = new BankAccount();
            var commands = new List<BankAccountCommand>
            {
            new BankAccountCommand(ba, BankAccountCommand.Action.Deposit, 100),
            new BankAccountCommand(ba, BankAccountCommand.Action.Withdraw, 1000)
            };

            WriteLine(ba);

            foreach (var c in commands)
                c.Call();

            WriteLine(ba);

            foreach (var c in Enumerable.Reverse(commands))
                c.Undo();

            WriteLine(ba);
        }
    }
}
