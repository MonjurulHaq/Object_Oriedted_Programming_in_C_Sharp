using System;

namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank b1 = new Bank(2000);
            double balanceWithoutInterest = b1.calculateCapital(500);
            double balanceWithInterest = b1.calculateCapital(500, 12);
            double strBalanceWithInterest = b1.calculateCapital("500", 12);
            Console.WriteLine(b1.balance);
            Console.WriteLine(b1.balance.GetType());
        }
    }
}

class Bank{
    public double balance;
    public Bank(int balance){
        this.balance = balance;
    }

    public double calculateCapital(double capital){
        balance+=capital;
        return balance;
    }

    public double calculateCapital(double capital, double interestRate){
        balance = balance + capital + (capital*interestRate)/100;
        return balance;
    }

     public double calculateCapital(string capital, double interestRate){
            double newCapital = Convert.ToDouble(capital);
            balance = balance + newCapital + (newCapital * interestRate)/100;
            return balance;
        }
}