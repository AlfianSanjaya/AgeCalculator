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
        }

        public void PrintAge()
        {
            Console.WriteLine($"The calculated age is {} year, {} months, {} days.");
        }
    }

    
}
