using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemN5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string S = "hello world";
            String reverseString = string.Empty;
            for (int i = S.Length-1; i >= 0; i--)
            {
                reverseString += S[i];
            }
            Console.WriteLine(reverseString);
        }
    }
}
