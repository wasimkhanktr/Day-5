using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenAndOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a no: " no);
            int no = Convert.ToInt32(Console.ReadLine());
            if (no % 2 == 0)
                Console.WriteLine("No is Even");
            else
                Console.WriteLine( + no "No is Odd");
        }
    }
}