using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * This program inputs the number of students in a class and tells how many groups they can be split into
 */
namespace Lecture_1
{
    internal class Example2
    {
        public static void FindClassGroups()
        {
            Console.WriteLine("Enter the number of students: ");
            int students = Int16.Parse(Console.ReadLine());
            int groups = 1;
            if (students % 2 == 0)
            {
                groups = 2;
            }
            else if (students % 3 == 0)
            {
                groups = 3;
            }
            else if (students % 5 == 0)
            {
                groups = 5;
            }
            else if (students % 7 == 0)
            {
                groups = 7;
            }
            Console.WriteLine("This class should have " + groups + " groups.");
        }
    }
}
