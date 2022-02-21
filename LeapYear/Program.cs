using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year in 4 digit YYYY: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0)
                Console.WriteLine("Leap year");
            else if (year % 4 == 0 && year % 100 != 0)
                Console.WriteLine(+year+ " is Leap year");
            else
                Console.WriteLine(+ year + " is Not Leap Year");
        }
    }
}