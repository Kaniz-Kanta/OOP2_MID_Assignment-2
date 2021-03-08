using System;
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
            if (base.Balance >= amount)
            {
                base.Balance = base.Balance - amount;
                Console.WriteLine(amount + " Withdraw Successfully!!");
                Console.WriteLine("Your Current Balance is---> " + base.Balance);
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