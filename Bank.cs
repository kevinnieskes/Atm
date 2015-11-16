using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ATM
{
    class Bank
    {
        public List<Account> accounts = new List<Account>();
        bool verified = false;
        int accountCounter = 0 ;
        public void CreateAccount(int pin , int balance)
        {
            int accountNumber = (accounts.Count);
            Account a = new Account(accountNumber, pin, balance);
            accounts.Add(a);
            Console.WriteLine("Account " + ("" + accountNumber) + " created with starting balance " + ("" + (balance)));
        }

        public bool Verify(int accountNum, int pin)
        {
            for (int x = 0; x < accounts.Count(); x++)
            {
                if ((accounts[x].accountNum == accountNum) && ((accounts[x].pin) == pin))
                {
                    verified = true;
                }
            }
            if (verified == true)
            {
                Console.WriteLine("Access Granted");
                return verified;
            }
            else
            {
                Console.WriteLine("Access Denied");
                return verified;
            }

        }

///       public void Transfer(float amount, int fromAccount, int toAccount)
///        {
///            balance += amount;
///            Console.WriteLine("Your new balance is " + ("" + balance));
///            Console.ReadLine();
///        }
    }
}
