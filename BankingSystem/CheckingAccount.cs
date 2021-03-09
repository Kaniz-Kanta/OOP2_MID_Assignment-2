using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BankingSystem
{
    public class CheckingAccount : Account
    {
        public CheckingAccount(int accountNumber, string userName, string dateOfBirth, double balance, string address) : base(accountNumber, userName, dateOfBirth, balance, address)
        {

        }
        public override void Withdraw(double amount)
        {
            if (Balance >= amount && amount > 0)
            {
                Balance = Balance - amount;
                IncrementTransaction();
            }
            else
            {
                Console.WriteLine("Withdraw not possible!!!");
            }
        }
        public override void ShowAccountInformation()
        {
            base.ShowAccountInformation();
        }



    }

}