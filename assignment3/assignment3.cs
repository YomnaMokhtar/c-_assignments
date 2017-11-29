using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static int choose_option()
        {
            Console.WriteLine("Choose an option from the following menu");
            Console.WriteLine("========================================");
            Console.WriteLine("[1] Search for a student degree");
            Console.WriteLine("[2] Get top student name and degree");
            Console.WriteLine("[3] Change a student's name");
            Console.WriteLine("Please enter your choice");
            int x = int.Parse(Console.ReadLine());
            return x;
        }
/*=========================================================================================*/
        static void getDegree(string[] nm, int[] dg)
        {
            Console.WriteLine("Please enter student name");
            string s = Console.ReadLine();
            int indx = Array.IndexOf(nm, s);
            Console.WriteLine("Student {0} score is {1}", s, dg[indx]);
        }
/*=========================================================================================*/
        static void getTopStudent(int c, string[] nm, int[] dg)
        {
            int max = dg[0];
            int indx = 0;
            for (int i = 1; i < c; i++)
            {
                if (dg[i] > max)
                {
                    max = dg[i];
                    indx = i;
                }
            }
            Console.WriteLine("Top student name is {0} and his degree equals {1}", nm[indx], max);
        }
/*=========================================================================================*/
        static void changename(ref string[] nm, int[] dg)
        {
            Console.WriteLine("Type the name of student to be changed (Old name)");
            string j = Console.ReadLine();
            Console.WriteLine("Enter new name");
            string h = Console.ReadLine();
            int indx = Array.IndexOf(nm, j);
            nm[indx] = h;
            Console.WriteLine("Name successfully changed from {0} to {1}", j, h);
        }
/*=========================================================================================*/

        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter number of students");
            num = int.Parse(Console.ReadLine());
            string[] names = new string[num];
            int[] dgrs = new int[num];
            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter Student {0} name", i+1);
                names[i] = Console.ReadLine();
                Console.WriteLine("Enter his degree");
                dgrs[i] = int.Parse(Console.ReadLine());
            }
            int x = choose_option();

            if (x == 1)
            {
                getDegree(names, dgrs);
            } else if(x == 2)
            {
                getTopStudent(num, names, dgrs);
               
            } else if(x == 3)
            {
                changename(ref names, dgrs);
            }
            Console.ReadLine();
        }
    }
}
