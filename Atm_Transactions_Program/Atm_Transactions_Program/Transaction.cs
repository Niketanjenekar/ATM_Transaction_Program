using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Atm_Transactions_Program
{
    internal class Transaction
    {
        private static int amount = 10000;
        public void TransactioN()
        {
            while (true)
            {
                int withdrawl, diposit;
                Console.WriteLine("Welcome to SBI ATM");
                Console.WriteLine("Please Enter your PIN : ");
                string aTM_pin = Console.ReadLine();
                string pin = "^[1-9]{4,6}$";
                if (Regex.IsMatch(aTM_pin, pin))
                {
                    Console.WriteLine("Please Choose the option : ");
                    Console.WriteLine("1. Check Balance");
                    Console.WriteLine("2. Cash Withdrawl");
                    Console.WriteLine("3. Cash Deposit");
                    Console.WriteLine("4. Exit");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:

                            if (Regex.IsMatch(aTM_pin, pin))
                            {
                                Console.WriteLine("The Balance in Your Account is : Rupees " + amount);
                            }
                            else
                            {
                                Console.WriteLine("PIN Entered is InCorrect ");
                            }
                            break;
                        case 2:
                            Console.WriteLine("Please Enter the Amount You need TO Withdrawl : ");
                            withdrawl = Convert.ToInt32(Console.ReadLine());
                            if (withdrawl < amount)
                            {
                                amount -= withdrawl;
                                Console.WriteLine("The Withdrawl of Amount is Rupees " + withdrawl);
                                Console.WriteLine("The Amount in Your Balance is : " + amount);
                            }
                            else
                            {
                                Console.WriteLine("Insufficient Balance");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Please Enter the Amount you want to Diposit : ");
                            diposit = Convert.ToInt32(Console.ReadLine());

                            if (diposit > 0)
                            {
                                amount += diposit;
                                Console.WriteLine("The amount of Rupees " + diposit + " has been Diposited to your Account");

                                Console.WriteLine("The Amount in Your Balance is : " + amount);
                            }
                            else
                            {
                                Console.WriteLine("Invalid Amount Entry");
                            }
                            break;
                        case 4:
                            Console.WriteLine("You are Exiting Atm Services ");
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid Entry");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please Enter the Correct PIN");
                }          
            }
            Console.ReadLine();
        }
    }
}
