using System;
using System.Collections.Generic;
using System.Text;

namespace AgeApp
{
    class AgeCalculator
    {
        private DateTime BirthDate { get; } = new DateTime();
        private DateTime CurrentDateTime { get; } = new DateTime();
        // Convert date string to DateTime in constructor
        public AgeCalculator(DateTime birtdate)
        {
            this.BirthDate = birtdate;
            this.CurrentDateTime = DateTime.Today;
        }


        
    }
}
