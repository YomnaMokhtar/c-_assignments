using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            string s;
            int n;
            double sum = 0;
            int j = 0;
            Console.WriteLine("Enter a hexadecimal number : ");
            Console.Write("0X");
            s = Console.ReadLine();           
            
            for(int i = s.Length-1; i>=0; i--)
            {
                x = Math.Pow(16, j);
                if(s[i] == 'A' || s[i] == 'a') 
                {
                    n = 10;
                }else if(s[i] == 'B' || s[i] == 'b' )
                {
                    n = 11;
                }
                else if (s[i] == 'C' || s[i] == 'c')
                {
                    n = 12;
                }
                else if (s[i] == 'D' || s[i] == 'd')
                {
                    n = 13;
                }
                else if (s[i] == 'E' || s[i] == 'e')
                {
                    n = 14;
                }
                else if (s[i] == 'F' || s[i] == 'f')
                {
                    n = 15;
                }else
                {
                    n = (int)s[i] - 48;
                }

                sum += n * x;
                j++;
            }
            Console.Write("The number you entered in decimal = ");
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
