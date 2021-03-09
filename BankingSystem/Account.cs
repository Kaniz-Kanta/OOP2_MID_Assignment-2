using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem

{
    public class Account
    {
        private int accountNumber;
        private string userName;
        private double balance;
        private string address;
        private string dateOfBirth;
        private int transactions = 0;
        private string accountType;
        //public int start = 10000;
        public Account(int accountNumber, string userName, string dateOfBirth, double balance, string address)
        {
            this.accountNumber = accountNumber;
            this.userName = userName;
            this.dateOfBirth = dateOfBirth;
            this.balance = balance;
            this.address = address;
        }
        public int GetAccountNumber()
        {
            return accountNumber;
        }
        public string UserName
        {
            get { return this.userName; }
            set { this.userName = value; }
        }
        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public string DateOfBirth
        {
            get { return this.dateOfBirth; }
            set { this.dateOfBirth = value; }
        }
        public int GetTransactions()
        {
            return this.transactions;
        }
        public string AccountType
        {
            get { return this.accountType; }
            set { this.accountType = value; }
        }
        public void IncrementTransaction()
        {
            this.transactions++;
        }
        virtual public void Withdraw(double amount)
        {

        }
        public void Deposite(double amount)
        {
            if (amount > 0)
            {
                this.balance = this.balance + amount;
                IncrementTransaction();
            }
            else
            {
                Console.WriteLine("Deposite not possible!!!!");
            }
        }
        public void Transfer(Account receiver, double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                receiver.Deposite(amount);
                Withdraw(amount);
                IncrementTransaction();
            }
            else
            {
                Console.WriteLine("Money transfer not possible!!!!");
            }
        }
        virtual public void ShowAccountInformation()
        {
            Console.WriteLine("-----------------Account Information ---------------\n");
            Console.WriteLine("Account No:{0}\nUserName:{1}\nAccount Type:{2}\nDate of Birth:{3}\nBalance:{4}\nAddress: {5}\n",
                accountNumber, this.userName, this.accountType, this.dateOfBirth, this.balance, this.address);
        }
    }
}
