using System;
using System.Collections.Generic;
using System.Text;

namespace AgeApp
{
    class EnterBirthDate
    {
        private DateTime BirthDate { get; } = new DateTime();
        public EnterBirthDate(DateTime datein)
        {
            this.BirthDate = datein;
        }
    }
}
