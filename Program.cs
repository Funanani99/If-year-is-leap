using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_year_is_leap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year1 = 2016;
            int year2 = 2018;

            bool isLeapYear1 = IsLeapYear(year1);
            bool isLeapYear2 = IsLeapYear(year2);

            Console.WriteLine($"{year1} is a leap year: {isLeapYear1}");
            Console.WriteLine($"{year2} is a leap year: {isLeapYear2}");
            Console.ReadLine();
        }

        static bool IsLeapYear(int year)
        {
            // A year is a leap year if it is divisible by 4.
            // However, if a year is divisible by 100, it is not a leap year,
            // unless it is also divisible by 400.
            return (year % 4 == 0) && ((year % 100 != 0) || (year % 400 == 0));
        }
    }
}
    

