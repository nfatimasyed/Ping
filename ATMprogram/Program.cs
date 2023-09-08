using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmSystem // Ref : youtube.com/-
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = 1000; // amt
            int deposit; // dep
            int withdraw; //wit
            int checkk; //ch
            int checkpin = 0; // pin 
            int x = 0;
            string hello;
            Console.WriteLine("please enter your pin number: ->   ");
            checkpin = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                Console.WriteLine(" ATM  Services: please select\n  ");
                Console.WriteLine("----------\n ");
                Console.WriteLine("1.check Account Balance\n ");
                Console.WriteLine("2. Withdraw\n ");
                Console.WriteLine("3. Deposit\n ");
                Console.WriteLine("4.Exit\n\n\n ");
                Console.WriteLine("Select Your Option\n->");

                checkk = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("hello! ");
                hello = Console.ReadLine();


                switch (checkk)
                {
                    case 1:
                        Console.WriteLine("\n\n Account Balance  {0}", amount);
                        break;
                    case 2:
                        Console.WriteLine("\n\n Amount Withdraw");
                        withdraw = Convert.ToInt32(Console.ReadLine());
                        if (withdraw % 100 != 0)
                        {
                            Console.WriteLine("\n\nEnter the Amount in Multiple of 100 ");
                        }
                        else if (withdraw > (amount - 200))
                        {
                            Console.WriteLine("\n\n Insufficient Fund");
                        }
                        else
                        {
                            amount = amount - withdraw;

                            Console.WriteLine("\n Take your Money");
                            Console.WriteLine("\nCurrent Balance is {0}", amount);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\n Deposit amount");
                        deposit = Convert.ToInt32(Console.ReadLine());
                        amount = amount + deposit;
                        Console.WriteLine("\nCurrent Balance {0}", amount);
                        break;
                    case 4:
                        Console.WriteLine("Thanks for using atm :");
                        break;
                }
            }


        }
    }
}









