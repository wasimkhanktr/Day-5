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
            Console.WriteLine("Enter the no of times to flip coin");
            int noOfTimesCoinsFlipped = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int heads = 0, tails = 0;
            int temp = noOfTimesCoinsFlipped;
            while (noOfTimesCoinsFlipped > 0)
            {
                if (random.NextDouble() <= 0.5)
                    heads++;
                else
                    tails++;
                noOfTimesCoinsFlipped--;
            }
            noOfTimesCoinsFlipped = temp;
            double percentageOfHead = heads * 100.0 / noOfTimesCoinsFlipped;
            double percentageOfTail = tails * 100.0 / noOfTimesCoinsFlipped;
            Console.WriteLine("Percentage of Head is " + percentageOfHead);
            Console.WriteLine("Percentage of tail is " + percentageOfTail);
        }
    }
}