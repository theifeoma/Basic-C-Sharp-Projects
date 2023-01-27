using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5test
{
    class BankAccountt
    {
        private string number;
        private double balance;

        public BankAccountt(string numb, double bal)
        {
            number = numb;
            balance = bal;
        }

        //constructor overload that takes in only one parameter while the other is always initialised to zero
        public BankAccountt(string num)
        {
            number = num;
            balance = 0;

        }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public bool Withdraw(double amount)
        {
            if (amount < balance)
            {
                balance -= amount;
                return true;
            }

            return false;
        }

        public double GetBalance()
        {
            return balance;
        }

        public string GetNumber()
        {
            return number;
        }

        public void Close()
        {
            balance = 0;
        }
    }
}

namespace Week5test
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccountt account1 = new BankAccountt("AB123", 100.0);
            BankAccountt account2 = new BankAccountt("CD456");
            BankAccountt account3 = new BankAccountt("EFG789", 300.34);
            account1.Deposit(200);
            account2.Deposit(130.5);
            Console.WriteLine($"Balance on {account1.GetNumber()}: {account1.GetBalance()}");
            Console.WriteLine($"Balance on {account2.GetNumber()}: {account2.GetBalance()}");
            Console.WriteLine($"Balance on {account3.GetNumber()}: {account3.GetBalance()}");
            double withdrawAmount = 200.35;
            bool isSuccessful = account1.Withdraw(withdrawAmount);

            if (isSuccessful)
            {
                Console.WriteLine($"Success! Balance on {account1.GetNumber()}: {account1.GetBalance()}");
            }
            else
            {
                Console.WriteLine($"Failed! Not enough money on {account1.GetNumber()}");
            }
            if (account2.Withdraw(withdrawAmount))
            {
                Console.WriteLine($"Success! Balance on account {account2.GetNumber()}: " +
               account2.GetBalance());
            }
            else
            {
                Console.WriteLine($"Failed! Not enough money on account {account2.GetNumber()}");
            }
            
            BankAccountt highest;
            if (account1.GetBalance() > account2.GetBalance())
            {
                highest = account1;
            }
            else
            {
                highest = account2;
            }
            Console.WriteLine($"Account {highest.GetNumber()} has the highest balance:{ highest.GetBalance()}");
            // account1.balance = 400;
            
            account2.Close();
            Console.WriteLine($"Account 2 has been closed and now has a balance of " + account2.GetBalance());
        }
    }
}
