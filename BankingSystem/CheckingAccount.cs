﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BankingSystem
{
    public class CheckingAccount : Account
    {
        
        public override void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance = Balance - amount;
                TransactionIncrement();
            }
            else
            {
                Console.WriteLine("Withdraw not possible!!! \n You must have minimum 100 taka in your SavingsAccount");
            }
        }
        public override void ShowAccountInformation()
        {
            base.ShowAccountInformation();
        }



    }

}