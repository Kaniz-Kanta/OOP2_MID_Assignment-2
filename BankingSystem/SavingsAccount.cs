using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class SavingsAccount : Account
    {
        public SavingsAccount(int accountNumber, string userName, double balance, Address address) : base(accountNumber, userName, balance, address);
        {
        }
        override public void Withdraw(double amount)
        {
            if ((base.balance - amount) >= 100)
            {
            base.balance = base.balance - amount;
            Console.WriteLine(amount + " Withdraw Successfully!!");
            }
            else
            {
            Console.WriteLine("Withdraw not possible!!! \n You must have minimum 100 taka in your SavingsAccount");
            }
        }
        override public void Deposite(double amount)
        { 
               base.balance = base.balance + amount;
               Console.WriteLine(amount + " Taka Deposited Successfully!!");
        }
        override public void Transfer(Account receiver, double amount)
        {
               receiver.Deposite(amount);
               base.Withdraw(amount);
               Console.WriteLine(amount + " Taka Transfered Successfully!!");
        }
}  
}

