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

                Options choice = new Options();
            choice.Choices();

                int userChoice = int.Parse(Console.ReadLine().Trim());
                int one = 1;
                int two = 2;
                int three = 3;
                int four = 4;
                int five = 5;

                //made a couple if else statements to declare on the choices the user was going
                //to pick and depending on the decision then a specific outcome will happen.
                if (userChoice == one)
                {
                    Client Info = new Client("Faizon", 03091996);
                    Info.ClientInfo();
                }

                //I believe the Methods were accurate and the more I did the more simple it got.

                else if (userChoice == two)
                {
                   
                }
                else if (userChoice == three)
                {
                    Console.WriteLine("[a] To Checking Account \n[b] To Savings Account");
                    string usrChoice = Console.ReadLine().ToLower();
                    string a = "a";
                    string b = "b";
                    if (usrChoice == a)
                    {
                        Checking Depo = new Checking();
                        Console.WriteLine("How much money would you like to deposit into your Checking Account?");
                        Console.WriteLine("Your total Amount in your checking account is {0}.");
                    }
                    else if (usrChoice == b)
                    {
                        Checking Depo = new Checking();
                        Console.WriteLine("How much money would you like to deposit into your Savings Account?");
                    }
                }
                else if (userChoice == four)
                {
                    Console.WriteLine("[a] Checking Account \n[b] Savings Account");
                    string usrChoice = Console.ReadLine().ToLower();
                    string a = "a";
                    string b = "b";
                    if (usrChoice == a)
                    {
                        Checking Depo = new Checking();
                        Console.WriteLine("How much money would you like to withdraw from your Checking Account?");
                        Console.WriteLine("Your total Amount in your checking account is {0}.");
                    }
                    else if (usrChoice == b)
                    {
                        Checking Depo = new Checking();
                        Console.WriteLine("How much money would you like to withdraw from your Savings Account?");
                    }
                }
                else if (userChoice == five)
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
