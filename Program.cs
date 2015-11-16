using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank first = new Bank();
            Account ein = new Account(0, 0000,100);
            Account one = new Account(1, 1111, 100);
            first.accounts.Add(ein);
            first.accounts.Add(one);
            first.CreateAccount(2222, 20000);
            //this tests that creataccount adds the account properly to accounts
            for (int x = 0; x < first.accounts.Count; x++)
                Console.WriteLine(first.accounts[x].accountNum);
            Console.ReadLine();
            //tests basic functions
            one.Deposit(1000);
            one.Deposit(1000);
            one.Withdraw(300);
            one.Deposit(1000);
            one.Withdraw(900);
            one.Deposit(10000);
            one.Withdraw(9998000);
            one.Deposit(1000);
            one.Withdraw(300);
            Console.ReadLine();
            // ATM test
            Atm zero = new Atm();
            zero.ExecuteInput(first);
            zero.ExecuteInput(first);
            zero.ExecuteInput(first);
            Console.ReadLine();



        }
            
    }
}
