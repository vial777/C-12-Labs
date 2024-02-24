using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_05
{
    public class Date
    {
        public int year;
        public int month;
        public int day;

        public int Year
        {
            get => year;
            set
            { 
                if(value > 0 && value < 10000)
                    year = value;
                else
                    throw new ArgumentOutOfRangeException("invalid year");
            }
        }
        public int Month
        {
            get => month;
            set
            {
                if (value >= 1 && value <= 12)
                    month = value;
                else
                    throw new ArgumentOutOfRangeException("invalid month");
            }
        }
        public int Day
        {
            get => day;
            set
            {
                if (value >= 1 && value <= 31)
                    day = value;
                else
                    throw new ArgumentOutOfRangeException("invalid day");
            }
        }

        public bool Validate()
        {
            if (Month == 2)
            {
                if (Year % 4 == 0 && Year % 100 != 0) // високосный год
                    return Day <= 29;
                else
                    return Day <= 28;
            }
            else
                if (Month <= 7)
                if (Month % 2 == 1)
                    return Day <= 31;
                else
                    return Day <= 30;
            else
                 if (Month % 2 == 1)
                    return Day <= 30;
                 else
                    return Day <= 31;

        }
        public Date(int year, int month, int day)
        {
            this.Year = year;
            this.Month = month;
            this.Day = day;
        }

        public Date() : this(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day) { }
        public void Print()
        {
            Console.WriteLine($"{Year}.{Month}.{Day}");
        }
    }
}
