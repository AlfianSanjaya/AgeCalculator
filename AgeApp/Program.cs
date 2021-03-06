﻿using System;
using System.Runtime.CompilerServices;

namespace AgeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // class Show -> methoden print welcome and age (thomas)
            // class EnterBirthday (alfian)
            // class agecalculator 

            bool RunningProgram = true;

            Show show = new Show();
            show.WelcomeMessage();

            while (RunningProgram == true)
            {
                int todo = show.Continue();
                if (todo == 1)
                {
                    // Age
                    EnterBirthDate enter = new EnterBirthDate();
                    enter.askBirthDate(show);

                }
                else if (todo == 2)
                {
                    // Quit
                    RunningProgram = false;
                }
                else
                {
                    Console.WriteLine("ERROR! Try again!");
                }
            }
        }
    }
}
