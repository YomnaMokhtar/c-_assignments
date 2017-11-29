using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string number = "";
            string m = "";
            string t = "";
            string x = "";
            string s = "";
            repeat:
            Console.WriteLine("please enter a number between 0 and 999!");
            n = int.Parse(Console.ReadLine());
            m = n.ToString();
            if (m == "0")
            {
                number = "zero";
                goto lable;
            }
            if (m.Length == 1)
            {
                t = "00";
                t += m;
                m = t;
                
            }
            else if (m.Length == 2)
            {
                t = "0";
                t += m;
                m = t;
            }
            if(m.Length > 3)
            {
                Console.WriteLine("Wrong number!!");
                goto repeat;
            }
            if(m[0] == '-')
            {
                Console.WriteLine("Wrong number!!");
                goto repeat;
            }

            switch (m[0])
            {
                case '0':
                    break;
                case '1':
                    number += "one hundred ";
                    break;
                case '2':
                    number += "two hundred ";
                    break;
                case '3':
                    number += "three hundred ";
                    break;
                case '4':
                    number += "four hundred ";
                    break;
                case '5':
                    number += "five hundred ";
                    break;
                case '6':
                    number += "six hundred ";
                    break;
                case '7':
                    number += "seven hundred ";
                    break;
                case '8':
                    number += "eight hundred ";
                    break;
                case '9':
                    number += "nine hundred ";
                    break;
            }

            switch (m[1])
            {
                case '0':
                    break;
                case '1':
                    if (m[2] == '0')
                    {
                        x = "ten ";
                    }
                    else if (m[2] == '1')
                    {
                        x = "eleven ";
                    }
                    else if (m[2] == '2')
                    {
                        x = "twelve ";
                    }
                    else if (m[2] == '3')
                    {
                        x = "thirteen ";
                    }
                    else if (m[2] == '4')
                    {
                        x = "fourteen ";
                    }
                    else if (m[2] == '5')
                    {
                        x = "fifteen ";
                    }
                    else if (m[2] == '6')
                    {
                        x = "sixteen ";
                    }
                    else if (m[2] == '7')
                    {
                        x = "seventeen ";
                    }
                    else if (m[2] == '8')
                    {
                        x = "eighteen ";
                    }
                    else if (m[2] == '9')
                    {
                        x = "nineteen ";
                    }
                    goto lable;
                    break;
                case '2':
                    s = "twenty ";
                    break;
                case '3':
                    s = "thirty ";
                    break;
                case '4':
                    s = "forty ";
                    break;
                case '5':
                    s = "fifty ";
                    break;
                case '6':
                    s = "sixty ";
                    break;
                case '7':
                    s = "seventy ";
                    break;
                case '8':
                    s = "eighty ";
                    break;
                case '9':
                    s = "ninety ";
                    break;
            }


            switch (m[2])
            {
                case '0':
                    if (m[0] != '0')
                    {
                        number += "and ";
                    }
                    number += s;
                    break;
                case '1':
                    number += s;
                    number += "one";
                    break;
                case '2':
                    number += s;
                    number += "two";
                    break;
                case '3':
                    number += s;
                    number += "three";
                    break;
                case '4':
                    number += s;
                    number += "four";
                    break;
                case '5':
                    number += s;
                    number += "five";
                    break;
                case '6':
                    number += s;
                    number += "six";
                    break;
                case '7':
                    number += s;
                    number += "seven";
                    break;
                case '8':
                    number += s;
                    number += "eight";
                    break;
                case '9':
                    number += s;
                    number += "nine";
                    break;
            }

        lable:
            if (m[1] == '1' && m[0] != '0')
            {
                number += "and ";
                number += x;
            }
            if (m[1] == '1' && m[0] == '0')
            {
                number += x;
            }
            Console.Write("the number you entered is : ");
            Console.WriteLine(number);
            Console.ReadLine();

        }
    }
}
