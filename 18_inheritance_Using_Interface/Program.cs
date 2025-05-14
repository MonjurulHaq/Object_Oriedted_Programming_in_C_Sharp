using System;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Card c = new Card();
            Paypal p = c;
            p.payment();
            Transaction t = c;
            t.compleateTransaction(6000);
        }
    }

    interface Paypal{
        public void payment();
    }

    interface Transaction{
        public void compleateTransaction(double balance);
    }

    class Card: Paypal, Transaction{
        protected double balance;
        public Card(){
            this.balance = balance;
        }

        void Paypal.payment(){
            Console.WriteLine("Making payment using paypal");
        }

        void Transaction.compleateTransaction(Double balance)
        {
            this.balance += balance;
            Console.WriteLine("The transaction is complete");
            Console.WriteLine($"New balance: {this.balance}");
        }
    }
}

