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
        private string bankName;
        private Account[] myBank = new Account[10];
        public Bank(string name)
        {
            this.bankName = name;
            Console.WriteLine(this.Name + "\n");
        }
        public string Name
        {
            set { this.bankName = value; }
            get { return this.bankName; }
        }
        public Account[] MyBank
        {
            set { this.myBank = value; }
            get { return this.myBank; }
        }

        public void AddAccount(Account account)
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    myBank[i] = account;
                    Console.WriteLine("Account Created Successfully!!!!!");
                    myBank[i].GanerateAccountNumber();
                    myBank[i].ShowAccountInformation();
                    break;
                }
            }
        }
        

        public void Transaction(int transactionType, [Optional] double amount, [Optional] int receiverAccountNumber)
        {
            Console.WriteLine("Enter a Account Number: ");
            int accountNumber = Convert.ToInt32(Console.ReadLine());
            int iReceiver = 0;
            bool check = false;
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }
                else if (transactionType == 1 && myBank[i].AccountNumber == accountNumber)
                {
                    myBank[i].Deposite(amount);
                    check = true;
                    break;
                }
                else if (transactionType == 2 && myBank[i].AccountNumber == accountNumber)
                {
                    myBank[i].Withdraw(amount);
                    check = true;
                    break;
                }
                else if (transactionType == 3 && myBank[i].AccountNumber == accountNumber && myBank[i].AccountNumber == receiverAccountNumber)
                {
                    iReceiver = i;
                    myBank[i].Transfer(myBank[iReceiver], amount);
                    check = true;
                    break;
                }

            }
            if (check == false)
            {
                Console.WriteLine("You Choose a Wrong Number!!!! ");
            }
        }
        public void ShowTransaction(int accountNumber)
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i].AccountNumber == accountNumber)
                {
                    Console.WriteLine("Total Transaction:{0}\nCurrent Balance:{1}", myBank[i].Transactions, myBank[i].Balance);
                }
            }
        }
        
    }
}
