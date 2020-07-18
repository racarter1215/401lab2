using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace Robert_Lab02
{
    public class Program
    {//below is a global variable that sets the money balance
        public static decimal Balance = 5000;
        /// <summary>
        /// below is a method that calls the userinterface method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            UserInterface();
        }
        /// <summary>
        /// below is the UserInterface method which contains prompts for the user to interact with, as well as the calls for all other methods
        /// </summary>
        public static void UserInterface()
        {
            Console.WriteLine("Welcome to the ATM!");
            //below is a vairable userNumber which, while blank now, denotes which number a user selected, hence which option they selected
            int userNumber;
            //below is a do while loop that allows the user to get back automatically to the main menu after an option is executed
            do
            {
                Console.WriteLine("Choose your next Transaction");
                Console.WriteLine("1 Deposit");
                Console.WriteLine("2 Withdraw");
                Console.WriteLine("3 Check your balance");
                Console.WriteLine("4 Exit");
                userNumber = int.Parse(Console.ReadLine());
                //below is an if else statement that sends a user to different areas depending on the number input
                if (userNumber == 1)
                {
                    Console.WriteLine("How much would you want to deposit?");
                    string userAnswer = Console.ReadLine();
                    decimal.TryParse(userAnswer, out decimal depositAmount);
                    //below is the call for the Deposit method with the user input passed through
                    Deposit(depositAmount);
                }
                else if (userNumber == 2)
                {
                    Console.WriteLine("How much would you like to withdraw?");
                    string userAnswer = Console.ReadLine();
                    decimal.TryParse(userAnswer, out decimal withdrawAmount);
                    //below is the call for the Withdraw method with the user input passed through
                    Withdraw(withdrawAmount);
                }
                else if (userNumber == 3)
                {
                    // below is the call for the viewbalance method with the current Balance passed in
                    ViewBalance(Balance);
                }
                else if (userNumber == 4)
                {//below is the exit statement
                    Console.WriteLine("Thank you for using the ATM, goodbye!");
                }
                //below is the exit from the while loop (if any number other than 4 is pressed, stay. If 4 is pressed, exit)
            } while (userNumber != 4);
        }
        /// <summary>
        /// below is a method that allows a user to insert "money" from the current Balance
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>the updated decimal Balance</returns>
        public static decimal Deposit(decimal amount)
        {//below is code that adds the current balance and deposited amount, and returning the new balance
            if(amount < 0)
            {
                Console.WriteLine($"Invalid amount deposited. Please try again");
            }
            else
            {
                decimal correctedBalance = Balance + amount;
                Balance = correctedBalance;

            }
            return Balance;
        }
        /// <summary>
        /// below is a method that allows a user to draw "money" from the current Balance
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>the updated decimal Balance</returns>
        public static decimal Withdraw(decimal amount)
        {//below is the code that subtracts the withdraw amount from the current balance, and returns the new balance
            if (amount > Balance)
            {
                Console.WriteLine($"You have insufficient funds, please try again");
            }
            else if (Balance < 0)
            {
                Console.WriteLine($"You cannot have a negative balance, please try again");
            }
            else if (amount < 0)
            {
                Console.WriteLine($"You cannot withdraw an invalid number, please try again");
            }
            else
            {
                decimal correctedBalance = Balance - amount;
                Balance = correctedBalance;
                Console.WriteLine($"You have withdrawn {amount}, and have {Balance} left in your account");
            }
            return Balance;
        }
        /// <summary>
        /// below is a method that allows the user to see the current amount of "money" they possess
        /// </summary>
        /// <param name="Balance"></param>
        /// <returns>the updated decimal Balance</returns>
        public static decimal ViewBalance(decimal Balance)
        {
            Console.WriteLine($"Your current balance is {Balance}");
            return Balance;
        }
    }
}