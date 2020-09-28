using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AgeApp
{
    class EnterBirthDate
    {
        private DateTime BirthDate { get; set; } = new DateTime();

        public void askBirthDate(Show show)
        {
            show.AskBirthDate();
            //CultureInfo provider = CultureInfo.InvariantCulture;
            string input = Console.ReadLine();
            this.BirthDate = Convert.ToDateTime(input);
            //this.BirthDate = DateTime.ParseExact(null, input, provider);
            Console.WriteLine("Your birtday is " + this.BirthDate);
        }
    }
}
