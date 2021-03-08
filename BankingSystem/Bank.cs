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
        private Account[] myBank;
        public Bank(string name, int size)
        {
            this.bankName = name;
            myBank = new Account[size];
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
                    myBank[i].ShowAccountInformation();
                    break;
                }
                else
                {
                    Console.WriteLine("---Add Account Not Possible For Now-----");
                }
            }
        }
        public void DeleteAccount(Account accountNumber)
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    myBank[i] = myBank[i + 1];
                    break;
                }
                else if (myBank[i] == accountNumber)
                {
                    myBank[i] = null;
                    myBank[i] = myBank[i + 1];
                    Console.WriteLine("Account Deleted!!!");
                    break;
                }
                else
                {
                    Console.WriteLine("Account Not Found!!!");
                }
            }
        }

        public void Transaction(int transactionType, [Optional] double amount, [Optional] int receiverAccountNumber)
        {

            switch (transactionType)
            {
                case 1:
                    {
                        Console.WriteLine("Enter an Account Number: ");
                        int accountNumber = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < myBank.Length; i++)
                        {
                            if (myBank[i] == null)
                            {
                                continue;
                            }
                            else if (myBank[i].GetAccountNumber() == accountNumber)
                            {
                                myBank[i].Deposite(amount);
                                Console.WriteLine(amount + " Taka Deposited Successfully!!");
                                break;
                            }
                        }
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Enter an Account Number: ");
                        int accountNumber = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < myBank.Length; i++)
                        {
                            if (myBank[i] == null)
                            {
                                continue;
                            }
                            else if (myBank[i].GetAccountNumber() == accountNumber)
                            {
                                myBank[i].Withdraw(amount);
                                Console.WriteLine(amount + " Withdraw Successfully!!");
                                Console.WriteLine("Your Current Balance is---> " + myBank[i].Balance);
                                break;
                            }
                        }
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Enter Senders Account Number: ");
                        int senderAccountNumber = Convert.ToInt32(Console.ReadLine());
                        int receiverIndex = 0;
                        for (int i = 0; i < myBank.Length; i++)
                        {
                            if (myBank[i] == null)
                            {
                                continue;
                            }
                            else if (myBank[i].GetAccountNumber() == receiverAccountNumber)
                            {
                                receiverIndex = i;
                                break;
                            }
                        }
                        for (int i = 0; i < myBank.Length; i++)
                        {
                            if (myBank[i] == null)
                            {
                                continue;
                            }
                            else if (myBank[i].GetAccountNumber() == senderAccountNumber)
                            {
                                myBank[i].Transfer(myBank[receiverIndex], amount);
                                Console.WriteLine(amount + " Taka Transfered Successfully!!");
                                Console.WriteLine("Your Current Balance is---> " + myBank[i].Balance);
                                break;
                            }
                        }
                    }
                    break;
            }
        }
        public void ShowTransaction(int accountNumber)
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i].GetAccountNumber() == accountNumber)
                {
                    Console.WriteLine("Total Transaction:{0}\nCurrent Balance:{1}", myBank[i].Transactions, myBank[i].Balance);
                }
            }
        }
        public void PrintAllAccountDetails()
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }
                myBank[i].ShowAccountInformation();
            }
        }
    }
}
