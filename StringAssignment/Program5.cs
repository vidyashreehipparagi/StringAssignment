using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{//occourance in the word
    internal class Program5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            String s1 = Console.ReadLine();
            Console.WriteLine("Enter word to find");
            String s2 = Console.ReadLine();

            string[] word = s1.Split(' ');
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == s2)
                {

                    count++;
                }
            }
            Console.WriteLine(count);
        }

    }
    }


