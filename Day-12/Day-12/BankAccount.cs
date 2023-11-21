using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_12
{
    public class BankAccount
    {
        readonly int AccountNumber;
        string AccountHoldername;
        double balance;
        double deposit;
        double withdraw;
        public BankAccount()
        {
            //AccountNumber = 15021535;
            Console.WriteLine("Bank constructor");
            AccountHoldername = "onkar";
            balance = 0;
        }

        public void Deposit()
        {
            Console.WriteLine("enter the deposit anount");
            deposit = int.Parse(Console.ReadLine());
            Console.WriteLine("deposited amount is " + deposit);
            balance += deposit;
            Console.WriteLine("total amount is " + balance);
        }
        public void Withdraw()
        {
            Console.WriteLine("enter withdraw amount");
            withdraw = int.Parse(Console.ReadLine());
            Console.WriteLine("withdrawn amount is " + withdraw);
            balance = balance - withdraw;
            Console.WriteLine("balance remaning is " + balance);
        }
        public void Display()
        {
           // Console.WriteLine("account number:"+AccountNumber);
            Console.WriteLine("account holder name:" + AccountHoldername);
            Console.WriteLine("account balance:" + balance);
        }
    }
}
