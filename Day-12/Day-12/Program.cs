﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.Display();
            account.Deposit();
            account.Display();
            account.Withdraw();
            account.Display();

            Console.ReadKey();
        }
    }
}
