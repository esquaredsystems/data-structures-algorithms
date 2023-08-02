using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * This program calculates average number of credit hours per semester for a student
 */
namespace Lecture_1
{
    internal class Example3
    {
        public static void CalculateAverageCredits()
        {
            Console.WriteLine("Enter the number of Semesters you have attended: ");
            int semesters = Int16.Parse(Console.ReadLine());
            int totalCredits = 0;
            for(int i = 1; i <= semesters; i++)
            {
                Console.WriteLine("Enter the number of credit hours in semester: " + i);
                int credits = Int16.Parse(Console.ReadLine());
                totalCredits += credits;
            }
            float average = (float) totalCredits / (float) semesters;
            Console.WriteLine($"On average, you earned {average:F} credits per semester.");
        }
    }
}
