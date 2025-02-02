using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_in_c_
{
    abstract class Bank 
    {
        // ye abstract class bngyi.. logo ko ye show hgi..isme function
        // ki details ni he.. tw wo logo ko show bhe nahi hgi

        // isme func ki details deskte hen .. flexible but interface me function ki 
        // details ni depaogi
        public abstract void deposit(decimal amount);
        public abstract void withdraw(decimal amount);
    }
    // It is a derived class from bank.. logo ko ye show nahi hgi or isi
    // me function ki details jyegi
    class SavingAccount : Bank
    {
        private decimal balance = 1000;
        // override is used when a derived class implementation to
        // a function that is already defined in base (abstract) class
        public override void deposit(decimal amount) {
            balance += amount;
            Console.WriteLine($"Deposited: {amount}");
            Console.WriteLine($"New Balance: {balance}");
        }
        public override void withdraw(decimal amount)
        {
            if(balance < amount)
            {
                Console.WriteLine("not enough balance");
            } else
            {
                balance -= amount;
                Console.WriteLine($"Withdraw: {amount}");
                Console.WriteLine($"New Balance: {balance}");
            }
        }
    }
    class Program
    {
        static void Main() {
            Bank account = new SavingAccount();
            account.deposit(200);
            account.withdraw(500);
            account.withdraw(2000); // not enough balance
        }
    }
}
