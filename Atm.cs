using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Atm
    {
        int accountNum;
        
        public bool SelectAccount(Bank bank)
        {
            Console.WriteLine("Enter Account Number: ");
            accountNum = (Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter Pin Number: ");
            int pin = (Convert.ToInt32(Console.ReadLine()));
            if (bank.Verify(accountNum, pin))
            {
                return true;
            }
            else
                return false;
        }
        

        public void ExecuteInput(Bank bank)
        {
            if (this.SelectAccount(bank))
            {
                string input;
                Console.WriteLine("Enter your transaction: (Use deposit or withdraw)");
                input = Console.ReadLine();
                if (input == "deposit")
                {
                    Console.WriteLine("Enter Deposit Amount: ");
                    float amount = (Convert.ToSingle(Console.ReadLine()));
                    (bank.accounts[accountNum]).Deposit(amount);
                }
                else if (input == "withdraw")
                {
                    Console.WriteLine("Enter Deposit Amount: ");
                    float amount = (Convert.ToSingle(Console.ReadLine()));
                    (bank.accounts[accountNum]).Withdraw(amount);
                }
                ///            else if (input == "transfer")
                ///            {
                ///                Console.WriteLine("Enter Transfer Amount: ");
                ///                float amount = (Convert.ToSingle(Console.ReadLine()));
                ///                Console.WriteLine("Enter Account Number To Transfer To: ");
                ///                int targetAccount = (Convert.ToInt32(Console.ReadLine()));
                ///                bank.Transfer(amount, a, targetAccount);
                ///            }
                ///            

                else
                    Console.WriteLine("Invalid Command. Please enter deposit or withdraw");
            }
            else if ((this.SelectAccount(bank)) == false)
            {
                Console.WriteLine("Access Denied. Re enter pin.");
            }   
            
        }
    }
}
