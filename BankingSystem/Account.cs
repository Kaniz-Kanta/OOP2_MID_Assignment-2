using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem

{
    public abstract class Account
    {
        private int accountNumber;
        private string userName;
        private double balance;
        private string address;
        private string dateOfBirth;
        private int transactions = 0;
        private string accountType;

        public void GanerateAccountNumber()
        {
            int start = 10000;
            this.accountNumber = start + 1;
            start++;
        }
        public int AccountNumber
        {
            get { return this.accountNumber; }
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
        public int Transactions
        {
            get { return this.transactions; }
        }
        public string AccountType
        {
            get { return this.accountType; }
            set { this.accountType = value; }
        }
        public void TransactionIncrement()
        {
            this.transactions++;
        }
        abstract public void Withdraw(double amount);
        public void Deposite(double amount)
        {
            if (amount > 0)
            {
                this.balance = this.balance + amount;
                Console.WriteLine(amount + " Taka Deposited Successfully!!");
                TransactionIncrement();
            }
        }
        public void Transfer(Account receiver, double amount)
        {
            if (amount > 0 && amount >= balance)
            {
                receiver.Deposite(amount);
                this.Withdraw(amount);
                Console.WriteLine(amount + " Taka Transfered Successfully!!");
                TransactionIncrement();
            }
        }
        virtual public void ShowAccountInformation()
        {
            Console.WriteLine("-----------------Account Information ---------------\n");
            Console.WriteLine("Account No:{0}\nUserName:{1}\nAccount Type:{2}\nDate of Birth:{3}\nBalance:{4}\nAddress: {5}\n",
                this.accountNumber, this.userName, this.accountType, this.dateOfBirth, this.balance, this.address);
        }
    }
}
