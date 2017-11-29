using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int p;

            Console.WriteLine("enter a number : ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter bit position : ");
            p = int.Parse(Console.ReadLine());

            int bit = n >> p - 1;
            int res = bit & 1;

            Console.WriteLine("The value of bit at position" + p + " = " + res );
            Console.ReadLine();
        }
    }
}
