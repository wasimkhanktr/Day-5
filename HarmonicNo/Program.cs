using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonicNo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Harmonic you want to find");
            int number = Convert.ToInt32(Console.ReadLine());
            double result = 0;
            for (double i = 1; i <= number; i++)
            {
                result += 1 / i;
            }
            Console.WriteLine("The Value of Harmonic " + number + " is " + result);
        }
    }
}