using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelConsonant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an alphabet");
            string alphabet = Console.ReadLine();
            if (alphabet == "i" || alphabet == "a" || alphabet == "e" || alphabet == "o" || alphabet == "u")
                Console.WriteLine(alphabet + " is a vowel");
            else
                Console.WriteLine(alphabet +" is a Consonant");
        }
    }
}