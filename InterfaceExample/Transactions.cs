using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample
{
    public class Transactions : interfaceClass
    {
        private int tid;
        private double amount;
        public Transactions(int tid, double amount)
        {
            this.tid = tid;
            this.amount = amount;
        }
        public double getAmount()
        {
            return amount;
        }
        public void showTransactions()
        {
            Console.WriteLine($"Transaction Id : {tid}");
            Console.WriteLine($"Amount Withdrawn: {amount}");
            Console.WriteLine();
        }

    }
}
