using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Date
    {
        private int day, month, year;
        public int Month
        {
            get { return this.month; }
            set
            {
                if (value < 0 || value > 12)
                    Console.WriteLine("Month is invalid.");
                else
                    this.month = value;
            }
        }

        public int Day
        {
            get { return this.day; }
            set
            {
                if (value < 0 || value > 31)
                    Console.WriteLine("Day is invalid.");
                else
                    this.day = value;
            }
        }

        public int Year
        {
            get { return this.year; }
            set
            {
                if (value < 0 || value > 2023)
                    Console.WriteLine("Yera is invalid.");
                else
                    this.year = value;
            }
        }
    }
}
