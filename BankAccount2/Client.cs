using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount2
{
    class Client
    {

        protected string name;
        protected int accNumber;

        public string Name { get; set; }
        public int AccNumber { get; set; }

        public Client()
        {

        }

        public Client(string name, int accountNumber)
        {
            this.name = "Faizon";
            this.accNumber = 391996;
        }

        public virtual void ClientInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Account Number: " + accNumber);
        }
    }
}
