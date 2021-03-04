using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class Program
    {
        static int GanerateAccountNumber(int i)
        {
            int start = 1000;
            int accountNumber = start + i;
            return accountNumber;
        }
        static void Main(string[] args)
        {
            Bank ourBank = new Bank();
            bool check = true;
            bool limit = true;
            while (limit)
            {
                Console.WriteLine("\n1) Open\n2) Account\n3) Quit");
                int manu1 = Convert.ToInt32(Console.ReadLine());
                switch (manu1)
                {
                    case 1://open account
                        
                            while (check)
                            {
                                Console.WriteLine("\n1) Open Savings Account\n2) Open Checking Account\n3) Quit");
                                int manu2 = Convert.ToInt32(Console.ReadLine());
                                if (manu2 == 1)
                                {
                                    Console.WriteLine("\nHow many account do you want to create?????");
                                    int size = Convert.ToInt32(Console.ReadLine());

                                    for (int i = 0; i < size; i++)
                                    {
                                        Console.WriteLine("\nAccount " + (i + 1) + "------");
                                        Console.WriteLine("UserName: ");
                                        string userName = Console.ReadLine();
                                        Console.WriteLine("Balance: ");
                                        double balance = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine("House no: ");
                                        string houseNo = Console.ReadLine();
                                        Console.WriteLine("Road no: ");
                                        string roadNo = Console.ReadLine();
                                        Console.WriteLine("City: ");
                                        string city = Console.ReadLine();
                                        Console.WriteLine("Country: ");
                                        string country = Console.ReadLine();
                                        ourBank.CreateSavingsAccount(new SavingsAccount(GanerateAccountNumber(i), userName, balance, new Address(houseNo, roadNo, city, country)));
                                    }
                                    break;
                                }
                                else if (manu2 == 2)
                                {
                                    Console.WriteLine("\nHow many account do you want to create?????");
                                    int size = Convert.ToInt32(Console.ReadLine());
                                    for (int i = 0; i < size; i++)
                                    {
                                        Console.WriteLine("\nAccount " + (i + 1) + "------");
                                        Console.WriteLine("UserName: ");
                                        string userName = Console.ReadLine();
                                        Console.WriteLine("Balance: ");
                                        double balance = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine("House no: ");
                                        string houseNo = Console.ReadLine();
                                        Console.WriteLine("Road no: ");
                                        string roadNo = Console.ReadLine();
                                        Console.WriteLine("City: ");
                                        string city = Console.ReadLine();
                                        Console.WriteLine("Country: ");
                                        string country = Console.ReadLine();
                                        ourBank.CreateCheckingAccount(new CheckingAccount(GanerateAccountNumber(i), userName, balance, new Address(houseNo, roadNo, city, country)));
                                    }
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("\n Press 0 for quit from this application \n");
                                    int quit = Convert.ToInt32(Console.ReadLine());
                                    if (quit == 0)
                                    {
                                        check = false;
                                    }
                                    break;
                                }
                            }
                                 break;
                    case 2://transaction

                            while (check)
                            {
                                Console.WriteLine("\n1) Deposite\n2) Withdraw\n3) Transfer\n4) Show\n5) Quit");
                                int manu3 = Convert.ToInt32(Console.ReadLine());
                                if (manu3 == 1)//deposite
                                {
                                    Console.WriteLine("\n 1) To Savings Account \n 2) To Checking Account \n---> ");
                                    int x = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Enter the Amount: ");
                                    double amount = Convert.ToDouble(Console.ReadLine());
                                    if (x == 1)
                                    {
                                        ourBank.SavingsAccountTransaction(manu3, amount);
                                    }
                                    else
                                    {
                                        ourBank.CheckingAccountTransaction(manu3, amount);
                                    }
                                }
                                else if (manu3 == 2)//withdraw
                                {
                                    Console.WriteLine("\n 1) To Savings Account \n 2) To Checking Account \n---> ");
                                    int x = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Enter the Amount: ");
                                    double amount = Convert.ToDouble(Console.ReadLine());
                                    if (x == 1)
                                    {
                                        ourBank.SavingsAccountTransaction(manu3, amount);
                                    }
                                    else
                                    {
                                        ourBank.CheckingAccountTransaction(manu3, amount);
                                    }

                                }
                                else if (manu3 == 3)//transfer
                                {
                                    Console.WriteLine("\n 1) To Savings Account \n 2) To Checking Account \n---> ");
                                    int x = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Enter the Amount: ");
                                    double amount = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Enter the Receivers AccountNumber: ");
                                    Account receiver = Convert.ToInt32(Console.ReadLine());
                                    if (x == 1)
                                    {
                                        ourBank.SavingsAccountTransaction(manu3, amount, receiver);
                                    }
                                    else
                                    {
                                        ourBank.CheckingAccountTransaction(manu3, amount, receiver);
                                    }
                                }
                                else if (manu3 == 4)//show
                                {
                                    Console.WriteLine("\n 1) To Savings Account \n 2) To Checking Account \n---> ");
                                    int x = Convert.ToInt32(Console.ReadLine());
                                    if (x == 1)
                                    {
                                        ourBank.PrintSavingsAccountDetails();
                                    }
                                    else
                                    {
                                        ourBank.PrintCheckingAccountDetails();
                                    }
                                }
                                else //quit
                                {
                                    Console.WriteLine("\n Press 0 for quit from this application \n");
                                    int quit = Convert.ToInt32(Console.ReadLine());
                                    if (quit == 0)
                                    {
                                        check = false;
                                    }
                                }
                            }
                             break;
                    case 3://quit
                        {
                            Console.WriteLine("\n Press 0 for Quit from this application \n");
                            int stop = Convert.ToInt32(Console.ReadLine());
                            if (stop == 0)
                            {
                                limit = false;
                            }
                        }
                        break;
                }

                
            }
        }
    }
}

