using System;
using System.Collections.Generic;
using System.Text;

namespace AgeApp
{
    class Show
    {
        public void WelcomeMessage()
        {
            Console.WriteLine("Hello! Welcome to the Age calculator!");
            Console.WriteLine("**************************************************");
            Console.WriteLine("We will use your birthdate to calculate your age.");

            System.Threading.Thread.Sleep(5000);

            Console.Clear();
        }

        public void AskBirthDate()
        {
            Console.WriteLine("What is your birthdate? (DD/MM/YYY)");
        }

        public void PrintAge()
        {
            Console.WriteLine($"The calculated age is  year,  months,  days.");
        }

        public int Continue()
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("*************************************");
            Console.WriteLine("1. Calculate a birthday          2. Quit");
            Console.WriteLine("Press enter after input to continue");

            string initchoice = Console.ReadLine();
            int choice = Convert.ToInt32(initchoice);

            return choice;
        }
    }

    
}
