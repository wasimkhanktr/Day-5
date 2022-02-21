using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of n between 0 and 31" +n);
            int n = Convert.ToInt32(Console.ReadLine());
            int year, ans = 1;
            for (int i = 0; i < n; i++)
                ans = ans * 2;
            year = ans;
            Console.WriteLine(ans);
            if (year % 400 == 0)
                Console.WriteLine("Leap year");
            else if (year % 4 == 0 && year % 100 != 0)
                Console.WriteLine("Leap year");
            else
                Console.WriteLine("Not Leap Year");
        }
    }
}