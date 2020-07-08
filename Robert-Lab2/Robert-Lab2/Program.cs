using System;

namespace Robert_Lab02
{
    public class Program
    {//below is a global variable that sets the money balance
        public static decimal Balance = 5000;
        //below is a method that calls the userinterface, which is the main menu
        static void Main(string[] args)
        {
            UserInterface();
        }
        //below is the method that is the main menu, from which a user can navigate several options
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
                    int depositAmount = Convert.ToInt32(userAnswer);
                    //below is the call for the Deposit method with the user input passed through
                    Deposit(depositAmount);
                }
                else if (userNumber == 2)
                {
                    Console.WriteLine("How much would you like to withdraw?");
                    string userAnswer = Console.ReadLine();
                    int withdrawAmount = Convert.ToInt32(userAnswer);
                    //below is the call for the Withdraw method with the user input passed through
                    Withdraw(withdrawAmount);
                }
                else if (userNumber == 3)
                {
                    //below is the user's current balance
                    Console.WriteLine($"Your current balance is {Balance}");
                }
                else if (userNumber == 4)
                {//below is the exit statement
                    Console.WriteLine("Thank you for using the ATM, goodbye!");
                }
                //below is the exit from the while loop (if any number other than 4 is pressed, stay. If 4 is pressed, exit)
            } while (userNumber != 4);
        }
        public static decimal Deposit(decimal amount)
        {//below is code that adds the current balance and deposited amount, and returning the new balance
            Balance += amount;
            return Balance;
        }

        public static decimal Withdraw(decimal amount)
        {//below is the code that subtracts the withdraw amount from the current balance, and returns the new balance
            Balance -= amount;
            return Balance;
        }
    }
}