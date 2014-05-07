using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reversed.cs
{
    class Program
    {
        public static string Reversed(string input)
        {
            string output = "";

            char[] seq = input.ToCharArray(); 

            return output;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");

            string input = Console.ReadLine();
            string output = Reversed(input);

            Console.WriteLine(output);
        }
    }
}
