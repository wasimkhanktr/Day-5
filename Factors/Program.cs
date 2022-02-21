using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factors
{
    internal class Program
    {
        public static int prime(int n)
        {
            int count = 0;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                    count++;
            }
            if (count > 0)
                return 0;
            else
                return 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a No");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    if (prime(i) == 1)
                        Console.Write( "\nprime no " + i + " is factor of  " + n );
                    
                }
            }
        }
       
    }
}