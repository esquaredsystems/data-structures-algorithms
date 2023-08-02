using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * This program inputs a year and tells whether the year is leap or not
 */
namespace Lecture_1
{
    internal class Example1
    {
        public static void FindLeapYear()
        {
            Console.WriteLine("Enter the year: ");
            int year = Int16.Parse(Console.ReadLine());
            bool leap = false;
            if (year % 4 == 0 && year % 100 != 0)
            {
                leap = true;
            }
            Console.WriteLine("Is " + year + " a leap year? " + leap);
        }
    }
}
