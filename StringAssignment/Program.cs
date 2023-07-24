using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string str = "hello good evening";
            int index1 = str.IndexOf('g');
            Console.WriteLine("The index value of character 'g'is " + index1);
            int index2 = str.IndexOf('e');
            Console.WriteLine("The index value of character 'e' is " + index2);
            Console.ReadLine();
        }
    }
}
