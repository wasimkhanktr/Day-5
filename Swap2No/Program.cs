using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap2No
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second numbers");
            int b = Convert.ToInt32(Console.ReadLine());
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("First no is " + a + "\nSecond no is " + b);
        }
    }
}