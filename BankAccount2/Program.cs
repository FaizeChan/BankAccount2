using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount2
{
    class Program
    {
        static void Main(string[] args)
        {

            string playAgain = "";

            do
            {
                //do while loop is needed to restart the program until break in [5] Exit

                Client Info = new Client("Faizon", 03091996);
                Checking checkingAct = new Checking();
                Savings savingAct = new Savings();



                Options choice = new Options();
            choice.Choices();

                int userChoice = int.Parse(Console.ReadLine().Trim());
                

                //made a couple if else statements to declare on the choices the user was going
                //to pick and depending on the decision then a specific outcome will happen.
                if (userChoice == 1)
                {
                    
                    Info.ClientInfo();
                }

                //I believe the Methods were accurate and the more I did the more simple it got.

                else if (userChoice == 2)
                {
                   Console.WriteLine("[a] To Checking Account \n[b] To Savings Account");
                    string usrChoice = Console.ReadLine().ToLower();
                    string a = "a";
                    string b = "b";
                    if (usrChoice == a)
                    {
                        checkingAct.Balance();
                        Console.WriteLine();
                    }
                    else if (usrChoice == b)
                    {
                        savingAct.Balance();
                        Console.WriteLine();
                    }
                }
                else if (userChoice == 3)
                {
                    Console.WriteLine("[a] To Checking Account \n[b] To Savings Account");
                    string usrChoice = Console.ReadLine().ToLower();
                    string a = "a";
                    string b = "b";
                    if (usrChoice == a)
                    {
                        Console.WriteLine("How much money would you like to deposit into your Checking Account?");
                        double depositAmount = double.Parse(Console.ReadLine());
                        checkingAct.Deposit(depositAmount);
                        checkingAct.Balance();
                        Console.WriteLine();
                    }
                    else if (usrChoice == b)
                    {
                        Console.WriteLine("How much money would you like to deposit into your Savings Account?");
                        double depositAmount = double.Parse(Console.ReadLine());
                        savingAct.Deposit(depositAmount);
                        savingAct.Balance();
                        Console.WriteLine();
                    }
                }
                else if (userChoice == 4)
                {
                    Console.WriteLine("[a] Checking Account \n[b] Savings Account");
                    string usrChoice = Console.ReadLine().ToLower();
                    string a = "a";
                    string b = "b";
                    if (usrChoice == a)
                    {
                        Console.WriteLine("How much money would you like to withdraw from your Checking Account?");
                        double withdrawingAmount = double.Parse(Console.ReadLine());
                        checkingAct.Withdraw(withdrawingAmount);
                        checkingAct.Balance();
                        Console.WriteLine();
                    }
                    else if (usrChoice == b)
                    {
                        Console.WriteLine("How much money would you like to withdraw from your Savings Account?");
                        double withdrawingAmount = double.Parse(Console.ReadLine());
                        savingAct.Withdraw(withdrawingAmount);
                        savingAct.Balance();
                        Console.WriteLine();
                    }
                }
                else if (userChoice == 5)
                {
                    Console.WriteLine();
                    Console.WriteLine("Thank you for choosing The United Banks.");
                    break;
                }

                //For choice number 5 which is the quit. I had the break take place since
                //the whole program class is in a loop which will have the user exit the system.

                else
                {
                    Console.WriteLine("Invalid input. Back to main menu.");
                }

                //The end of do while loop to restart the program until break in [5] Exit

                playAgain = Console.ReadLine().ToLower();
            } while (playAgain == "");
        }
    }
}
