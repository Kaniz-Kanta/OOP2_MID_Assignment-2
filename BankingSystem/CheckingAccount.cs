﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class CheckingAccount:Account
    {
        public CheckingAccount(int accountNumber, string userName, double balance, Address address) : base(accountNumber, userName, balance, address);
        {
        }
        override public void Withdraw(double amount)
        {
        if (base.balance >= amount)
        {
            base.balance = base.balance - amount;
            Console.WriteLine(amount + " Withdraw Successfully!!");
        }
        else
        {
            Console.WriteLine("Withdraw not possible!!! \n You must have minimum 100 taka in your SavingsAccount");
        }
        }
        public void Deposite(double amount)
        {
               base.balance = base.balance + amount;
               Console.WriteLine(amount + " Taka Deposited Successfully!!");
        }
        public void Transfer(Account receiver, double amount)
        {
               receiver.Deposite(amount);
               base.Withdraw(amount);
               Console.WriteLine(amount + " Taka Transfered Successfully!!");
        }
   
}
}
