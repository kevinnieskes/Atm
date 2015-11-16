using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Account
    {
        public int accountNum;
        public int pin;
        float balance;

        public Account(int Num, int pinNum, float balanceNum)
        {
            accountNum = Num;
            pin = pinNum;
            balance = balanceNum ;
        }
        public void Withdraw(float amount)
        {
            if ((balance - amount) <= 0.00)
            {
                Console.WriteLine("Insufficent Funds!");
            }
            else
            {
                balance -= amount;
                Console.WriteLine("Your new balance is " + ("" + balance));
            }
        }

        public void Deposit(float amount)
        {
            balance += amount;
            Console.WriteLine("Your new balance is " + ("" + balance));
        }

        public float CheckBalance()
        {
            return balance;
        }


    }
}
