using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount2
{
    class Options
    {
        public void Choices()
        {
            Console.WriteLine("Welcome to The United Banks. \nPress one of the following numbers displayed");
            Console.WriteLine();

            //This class is just putting in Console writeline to make the
            //user understand what they have to do. Simply press 1 through 5

            Console.WriteLine("[1] View Client Information");
            Console.WriteLine("[2] View Account Balance");
            Console.WriteLine("[3] Deposit Funds");
            Console.WriteLine("[4] Withdraw Funds");
            Console.WriteLine("[5] Exit");
        }
    }
}
