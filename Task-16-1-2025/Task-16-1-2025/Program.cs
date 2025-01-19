using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Task_16_1_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Create console application that read string from user and print the same string
            Console.WriteLine("write your name ");
            string name = Console.ReadLine();
            Console.WriteLine(name);

            //2 - Define variables with kind of
            //      a.Double
            //      b.String
            //      c.Char
            //      d.Bool
            //      e.Int
            //      f.Const
            double d = 2.3;
            Console.WriteLine(d);
            string s = "Mona";
            Console.WriteLine(s);
            char c = 'A';
            Console.WriteLine(c);
            bool b = false;
            Console.WriteLine(b);
            int t = 0;
            Console.WriteLine(t);
            const int e = 1;
            Console.WriteLine(e);

            //3 - Define array with name car that hold more than 3 kinds on cars, then print all the cars with the array length.

            string[] cars = { "mercedes", "range rover", "toyota", "ford" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }


            //4 - Write a program in C that reads a first name, Lastname and year of birth and display the names and the year one after another sequentially.Go to the editor
            //    •	Input your firstname: Sami
            //    •	Input your lastname: Ali
            //    •	Input your year of birth: 1999
            //    •	Sami Ali 1999
            Console.WriteLine("write your first name ");
            string firstName = Console.ReadLine();
            Console.WriteLine("write your last name ");
            string lastName = Console.ReadLine();
            Console.WriteLine("write your birth year ");
            string year = Console.ReadLine();
            Console.WriteLine(firstName + " " + lastName + " " + year);

            //5 - Write a program in C # to store elements in an array and print it. 
            //    •	Test Data :	
            //    •	Input 10 elements in the array :
            //    •	element - 0 : 1
            //    •	element - 1 : 1
            //    •	element - 2 : 2
            //    •	.......
            //    •	Expected Output :
            //    •	Elements in array are: 1 1 2 3 4 5 6 7 8 9

            string[] num = new string[10];

            for (int n = 0; n < num.Length; n++)
            {
                Console.WriteLine($"element - {n} : ");
                num[0] = Console.ReadLine();
            }
            for (int n = 0; n < num.Length; n++)
            {
                Console.WriteLine(n);
            }

           








        }
    }
}
