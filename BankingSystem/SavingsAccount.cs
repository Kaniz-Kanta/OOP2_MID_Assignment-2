using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BankingSystem
{
    public class SavingsAccount : Account
    {
        public SavingsAccount(int accountNumber, string userName, string dateOfBirth, double balance, string address) : base(accountNumber, userName, dateOfBirth, balance, address)
        {

        }
        public override void Withdraw(double amount)
        {
            if ((base.Balance - amount) >= 100 && amount > 0)
            {
                Balance = Balance - amount;
                IncrementTransaction();
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