using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem

{
    abstract class Account
    {
        private  int accountNumber;
        private string userName;
        private double balance;
        private Address address;
        
        public Account(int accountNumber, string userName, double balance, Address address)
        {
            this.accountNumber = accountNumber;
            this.userName = userName;
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
        public Address Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        abstract public void Withdraw(double amount);
        abstract public void Deposite(double amount);
        abstract public void Transfer(Account receiver, double amount);
        public void ShowAccountInformation()
        {
            Console.WriteLine("-----------------Your Account Information ---------------\n");
            Console.WriteLine("Account No:{0}\n UserName:{1}\nBalance:{2}\nAddress:{3}",
                this.accountNumber, this.userName, this.balance, this.address.GetAddress());
        }
    }
}
