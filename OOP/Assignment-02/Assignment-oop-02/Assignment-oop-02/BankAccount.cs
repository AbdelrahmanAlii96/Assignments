using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_oop_02
{
    public class BankAccount
    {
        private string _owner;
        private double _banalce;

        public string Owner
        {
            get { return _owner; }
        }


        public double Banalce
        {
            get { return _banalce; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Balance can't be negative");
                }
                else
                {
                    _banalce = value;
                }
                    
            }
        }

        //Read only checking negative balance
        public bool Isoverdrawn
        {
            get { return _banalce < 0; }
        }
        public void withdraw(double amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Amount must be Postive");
            }
            if (amount > _banalce)
            {
                Console.WriteLine("insufficient funds");
            }
            _banalce -= amount;
        }
    }
}
