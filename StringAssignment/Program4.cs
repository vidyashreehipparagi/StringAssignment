using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    internal class Program4
    {//Write a program to trim leading white space characters in a string.
        static void Main(string[] args)
        {
            {
                string str = "   .....Today is good day";
                Console.WriteLine(str.TrimStart());
            }

        }
    }
}
