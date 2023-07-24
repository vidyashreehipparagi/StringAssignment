using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    internal class Program8
    {
        static void Main(string[] args)
        {
            //occurance in char
            string str = "hello good evening";
            Console.WriteLine("enter any character");
            char ch = Convert.ToChar(Console.ReadLine());
            char[] arr = str.ToCharArray();
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (ch == arr[i])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

    }
}
