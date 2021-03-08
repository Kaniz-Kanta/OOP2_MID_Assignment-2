using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class Program
    { 

        static void Main(string[] args)
        {
            Bank ourBank = new Bank("**********DEVELOPERS BANK***********",10);
            Console.WriteLine("...........WELCOME TO OUR SYSYTEM............\n");
            bool check = true;
            bool limit = true;
            while (limit)
            {
                Console.WriteLine("---------Please Choose A Survice You Want--------------\n");
                Console.WriteLine("___________________________________________________\n");
                Console.WriteLine(" open---->Open an account\n account----->Perform transactions on an account\n quit----->Exit the application");
                Console.WriteLine("___________________________________________________");
                string menu1 = Console.ReadLine();
                switch (menu1)
                {
                    case "open"://open account
                                Console.WriteLine("\n___________________________________________________\n");
                                Console.WriteLine("1) Savings----->Open Savings Account\n2) Checking---->Open Checking Account\n3) Back---->Go back from this menu\n4) Quit----->Exit the application");
                                Console.WriteLine("___________________________________________________\n");
                                int menu2 = Convert.ToInt32(Console.ReadLine());
                                if (menu2 == 1)
                                {
                                    Console.WriteLine("\nHow many account do you want to create?????");
                                    int size = Convert.ToInt32(Console.ReadLine());
                                    for (int i = 0; i < size; i++)
                                    {
                                        Account obj = new SavingsAccount();
                                        Console.WriteLine("\nAccount " + (i + 1) + "------>");
                                        Console.WriteLine("UserName: ");
                                        obj.UserName = Console.ReadLine();
                                        Console.WriteLine("Date Of Birth: ");
                                        obj.DateOfBirth = Console.ReadLine();
                                        Console.WriteLine("Balance: ");
                                        obj.Balance = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine("Address:--House No, Road No, City, Country\n     ");
                                        obj.Address = Console.ReadLine();
                                        obj.AccountType = "Savings Account";
                                        ourBank.AddAccount(obj);
                                    }
                                    break;
                                }
                                else if (menu2 == 2)
                                {
                                    
                                    Console.WriteLine("\nHow many account do you want to create?????");
                                    int size = Convert.ToInt32(Console.ReadLine());
                                    for (int i = 0; i < size; i++)
                                    {
                                        Account obj = new CheckingAccount();
                                        Console.WriteLine("\nAccount " + (i + 1) + "------>");
                                        Console.WriteLine("UserName: ");
                                        obj.UserName = Console.ReadLine();
                                        Console.WriteLine("Date Of Birth: ");
                                        obj.DateOfBirth = Console.ReadLine();
                                        Console.WriteLine("Balance: ");
                                        obj.Balance = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine("Address:--House No, Road No, City, Country\n       ");
                                        obj.Address = Console.ReadLine();
                                        obj.AccountType = "Checking Account";
                                        ourBank.AddAccount(obj);
                                   }
                                    break;
                                }
                                else if(menu2==3)
                                {
                                   while (check)
                                   {
                                    Console.WriteLine("\n---------Thanks for being with us--------");
                                    Console.WriteLine("Press 0 for back from this menu ");
                                    int back = Convert.ToInt32(Console.ReadLine());
                                    if (back == 0)
                                    {
                                        check = false;
                                    }
                                    break;
                                   }
                                }
                                else
                                {
                                    Console.WriteLine("\n---------Thanks for being with us--------");
                                    Console.WriteLine("Press 0 for quit from this application ");
                                    int quit = Convert.ToInt32(Console.ReadLine());
                                    if (quit == 0)
                                    {
                                        limit = false;
                                    }
                                    break;
                                 }
                                break;
                    case "account"://transaction
                                Console.WriteLine("\n___________________________________________________\n");
                                Console.WriteLine("1) Deposite---->Make a deposite\n2) Withdraw---->Make a withdrawal\n3) Transfer---->Make a transfer\n4) Show---->Show the number transactions and balance\n5) Back---->Go back from this menu\n6) Quit---->Exit the application");
                                Console.WriteLine("___________________________________________________\n");
                                int menu3 = Convert.ToInt32(Console.ReadLine());
                                if (menu3 == 1)//deposite
                                {
                                    Console.WriteLine("Enter the Amount: ");
                                    double amount = Convert.ToDouble(Console.ReadLine());
                                    ourBank.Transaction(menu3, amount);
                                }
                                else if (menu3 == 2)//withdraw
                                {
                                    Console.WriteLine("Enter the Amount: ");
                                    double amount = Convert.ToDouble(Console.ReadLine());
                                    ourBank.Transaction(menu3, amount);
                                }
                                else if (menu3 == 3)//transfer
                                {
                                    Console.WriteLine("Enter the Amount: ");
                                    double amount = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Enter the Receivers AccountNumber: ");
                                    int receiverAccountNumber = Convert.ToInt32(Console.ReadLine());
                                    ourBank.Transaction(menu3, amount, receiverAccountNumber);
                                }
                                else if (menu3 == 4)//show
                                {
                                    Console.WriteLine("Enter an Account Number: ");
                                    int accountNumber = Convert.ToInt32(Console.ReadLine());
                                    ourBank.ShowTransaction(accountNumber);
                                }
                                else if (menu3 == 5)//back
                                {
                                    while (check)
                                    {
                                        Console.WriteLine("\n---------Thanks for being with us--------");
                                        Console.WriteLine("Press 0 for back from this menu ");
                                        int back = Convert.ToInt32(Console.ReadLine());
                                        if (back == 0)
                                        {
                                            check = false;
                                        }
                                        break;
                                    }
                                }
                                else //quit
                                {
                                          Console.WriteLine("\n ---------Thanks for being with us--------\n");
                                          Console.WriteLine("\n Press 0 for quit from this application \n");
                                          int quit = Convert.ToInt32(Console.ReadLine());
                                          if (quit == 0)
                                          {
                                              limit = false;
                                          }
                                }
                                     break;
                    case "quit"://quit
                        {
                            Console.WriteLine("\n---------Thanks for being with us--------");
                            Console.WriteLine("Press 0 for Quit from this application");
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

