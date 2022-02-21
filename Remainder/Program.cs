using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dividend, divisor, quotient, remainder;
            Console.WriteLine("Enter Dividend and divisor");
            dividend = Convert.ToInt32(Console.ReadLine("Dividend"));
            divisor = Convert.ToInt32(Console.ReadLine("Divisor"));
            quotient = dividend / divisor;
            remainder = dividend % divisor;
            Console.WriteLine("Quotient is = " + quotient);
            Console.WriteLine("Remainder is = " + remainder);
        }
    }
}