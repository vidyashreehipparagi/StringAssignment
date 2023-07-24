using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    internal class Program6
    {//String function
        static void Main(string[] args)
        {
            string myName = "Vidyashree Hipparagi";
            Console.WriteLine(myName);
            Console.WriteLine(myName[0]);
            Console.WriteLine(myName.Length);
            Console.WriteLine(myName.IndexOf('V'));
            Console.WriteLine(myName.LastIndexOf('a'));
            Console.WriteLine(myName.ToLower());
            Console.WriteLine(myName.ToUpper());
            Console.WriteLine(myName.Contains("Vidyashree"));
            Console.WriteLine(myName.Equals("vidyashee hippargi"));
            Console.WriteLine(myName.GetHashCode());
            Console.WriteLine(myName.Count());
            string myName1 = "Vidya";
            string s = string.Concat(myName, myName1);
            Console.WriteLine(s);
        }
    }
}
