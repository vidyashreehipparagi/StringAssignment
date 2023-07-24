using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    internal class Program9
    {
        static void Main(string[] args)
        {
            //Write a program to count total number of words in a string.
            string str;
            int i, word, l;
            Console.WriteLine("Enter words");
            str = Console.ReadLine();
            l = 0;
            word = 1;
            while (l <= str.Length - 1)
            {
                if (str[l] == ' ' || str[l] == '\n' || str[l] == '\t')
                {
                    word++;

                }
                l++;
            }
            Console.WriteLine(word);

        }
    }
}
