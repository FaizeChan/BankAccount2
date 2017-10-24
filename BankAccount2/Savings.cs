using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount2
{
    class Savings : Accounts
    {

        public double savingsBase;

        public double SavingsBase { get; set; }

        //My set savings balance
        public Savings()
        {
            this.savingsBase = 1000.00;
        }


        public override void Balance()
        {
            base.Balance(); Console.WriteLine("Savings Balance is now $" + (viewBalance + savingsBase));
        }
    }
}