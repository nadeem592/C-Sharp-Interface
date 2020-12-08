using System;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Transactions t1 = new Transactions(1,210.10);
            Transactions t2 = new Transactions(2, 22.2);
            Transactions t3 = new Transactions(3, 32.3);
            Transactions t4 = new Transactions(4, 90.32);
            t1.showTransactions();
            t2.showTransactions();
            t3.showTransactions();
            t4.showTransactions();
            
        }
    }
}
