using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class Bank
    {
        private SavingsAccount[] saving;
        private CheckingAccount[] checking;
        public SavingsAccount[] Saving
        {
            set { this.saving = value; }
            get { return this.saving; }
        }
        public CheckingAccount[] Checking
        {
            set { this.checking = value; }
            get { return this.checking; }
        }
        public void CreateSavingsAccount(SavingsAccount account)
        {
            for (int i = 0; i < saving.Length; i++)
            {
                if (saving[i] == null)
                {
                    saving[i] = account;
                    Console.WriteLine("-----------------Your Savings Account Created Succesfully---------------");
                    break;
                }
            }
        }
        public void CreateCheckingAccount(CheckingAccount account)
        {
            for (int i = 0; i < checking.Length; i++)
            {
                if (checking[i] == null)
                {
                    checking[i] = account;
                    Console.WriteLine("-----------------Your Checking Account Created Succesfully---------------");
                    break;
                }
            }
        }

        public void SavingsAccountTransaction(int transactionType, [Optional] double amount, [Optional] Account receiver)
        {
            Console.WriteLine("Enter a Account Number: ");
            int accountNumber = Convert.ToInt32(Console.ReadLine());
            bool check = false;
            for (int i = 0; i < saving.Length; i++)
            {
                if (saving[i] == null)
                {
                    continue;
                }
                else if (transactionType == 1 && saving[i].GetAccountNumber() == accountNumber)
                {
                    saving[i].Deposite(amount);
                    check = true;
                    break;
                }
                else if (transactionType == 2 && saving[i].GetAccountNumber() == accountNumber)
                {
                    saving[i].Withdraw(amount);
                    check = true;
                    break;
                }
                else if (transactionType == 3 && saving[i].GetAccountNumber() == accountNumber)
                {
                    saving[i].Transfer(receiver, amount);
                    check = true;
                    break;
                }
                
            }
            if(check==false)
            {
                Console.WriteLine("You Choose a Wrong Number!!!! ");
            }
        }
        public void CheckingAccountTransaction(int transactionType, [Optional] double amount, [Optional] Account receiver)
        {
            Console.WriteLine("Enter a Account Number: ");
            int accountNumber = Convert.ToInt32(Console.ReadLine());
            bool check = false;
            for (int i = 0; i < checking.Length; i++)
            {
                if (checking[i] == null)
                {
                    continue;
                }
                else if (transactionType == 1 && checking[i].GetAccountNumber() == accountNumber)
                {
                    checking[i].Deposite(amount);
                    check = true;
                    break;
                }
                else if (transactionType == 2 && checking[i].GetAccountNumber() == accountNumber)
                {
                    checking[i].Withdraw(amount);
                    check = true;
                    break;
                }
                else if (transactionType == 3 && checking[i].GetAccountNumber() == accountNumber)
                {
                    checking[i].Transfer(receiver, amount);
                    check = true;
                    break;
                }

            }
            if (check == false)
            {
                Console.WriteLine("You Choose a Wrong Number!!!! ");
            }
        }
        public void PrintSavingsAccountDetails()
        {
            for (int i = 0; i < saving.Length; i++)
            {
                if (saving[i] == null)
                {
                    continue;
                }
                saving[i].ShowAccountInformation();
            }
        }
        public void PrintCheckingAccountDetails()
        {
            for (int i = 0; i < checking.Length; i++)
            {
                if (checking[i] == null)
                {
                    continue;
                }
                checking[i].ShowAccountInformation();
            }
        }
    }
}
