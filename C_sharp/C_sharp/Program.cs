using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_19_1_2025
{
    internal class Program
    {
        static double convertToMile(double x)
        {
            return x * 0.621371;
        }
        static int numberOfMinutes(int h, int m)
        {
            int t = h * 60 + m;
            return t;
        }
        static void numberOfhours(double m)
        {
            int hours = 0;
            while (m > 60)
            {
                hours++;
                m -= 60;
            }

            Console.WriteLine($"{hours} Hours,{m} Minutes");
        }
        static string Compare(int x, int y)
        {
            if (x > y)
            {
                return "Greater";
            }
            else if (x < y)
            {
                return "Smaller";
            }
            else
            {
                return "Equal";
            }
        }
        static int sum(int x, int y)
        {
            return x + y;
        }
        static string Divisibility(int x, int y)
        {
            if (x % y == 0)
            {
                return "Divisible";
            }
            else
            {
                return "Not Divisible";
            }

        }
        static string Middle(int x, int y, int z)
        {
            if ((x > y && x < z) || (x > z && x < y))
            {
                return "The middle value is: " + x;
            }
            else if ((y > x && y < z) || (y > z && y < x))
            {
                return "The middle value is: " + y;
            }
            else if ((z > x && z < y) || (z > y && z < x))
            {
                return "The middle value is: " + z;
            }
            return "Please enter 3 numbers";
        }
        static void Main(string[] args)
        {
            //1 - Write a C# program that accepts a double input and converts it into an int. Display both values.
            double a = 10.33;
            int A = (int)a;
            Console.WriteLine("Double: " + a);
            Console.WriteLine("Converted Int: " + A);

            //2 - Write a program that uses a Convert.ToString() method to convert a number into 
            //    a string and concatenate it with a sentence.
            int b = 23;
            string B = Convert.ToString(b);
            Console.WriteLine("I'm Mona & my age is " + B);

            //3 - Create a string with a sentence. Use ToUpper() and ToLower() to display 
            //    the uppercase and lowercase versions of the string.
            string c = "Mona Tamimi";
            Console.WriteLine(c.ToUpper());
            Console.WriteLine(c.ToLower());

            //4 - Write a program that takes a user's full name as input and prints:
            //    The first name.
            //    The last name.
            //    The length of the full name.
            Console.WriteLine("write your first and last name: ");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine(name.Length);

            //5 - Write a program that accepts two integers and prints the smaller of the two.
            Console.WriteLine("write number :");
            string num1 = Console.ReadLine();
            int num11 = int.Parse(num1);
            Console.WriteLine("write anther number :");
            string num2 = Console.ReadLine();
            int num22 = int.Parse(num2);
            if (num11 < num22)
            {
                Console.WriteLine("Smaller Number: " + num11);
            }
            else
            {
                Console.WriteLine("Smaller Number: " + num22);
            }

            //6 - Write a method that converts kilometers per hour to miles per hour.
            //    Use this method in a program to convert and display the result.
            Console.WriteLine(convertToMile(100));

            //7 - Write a method that takes hours and minutes as input and returns the total number of minutes.
            Console.WriteLine("Total = " + numberOfMinutes(5, 40) + " minutes.");

            //8 - Write a method that accepts minutes as input and calculates the total number of hours and minutes.
            numberOfhours(550);

            //9 - Compare Two Numbers
            //    Write a program that prints:
            //    "Equal" if two numbers are the same.
            //    "Greater" if the first is greater.
            //    "Smaller" if the second is greater.
            //    Use only comparison and ternary operators.
            //    •	Input: 10, 20
            //    •	Output: "Smaller"
            Console.WriteLine(Compare(4, 9));

            //    Sum of Digits
            //    Write a program that calculates the sum of the digits of a number using arithmetic operators and loops(no conditionals).
            //    Input: 123
            //    Output: "Sum of digits: 6"
            Console.WriteLine(sum(5, 8));

            //10 - Reverse a Number
            //Write a program that reverses a number using arithmetic operators and loops.
            Console.WriteLine("write sequence of num :");
            string d = Console.ReadLine();
            char[] stringArray = d.ToCharArray();
            Array.Reverse(stringArray);
            string reversedStr = new string(stringArray);
            Console.WriteLine("Reversed Number: " + reversedStr);

            //11 - Check Divisibility
            //    Write a program to check if a number is divisible by another number using
            //    logical and arithmetic operators. Return a message "Divisible" or "Not Divisible".
            //    Input: 25, 5
            //    Output: "Divisible"
            Console.WriteLine(Divisibility(100, 3));

            //12 - Find the Middle Value
            //Write a program to find the middle value of three numbers using arithmetic and comparison operators.
            //Input: 15, 20, 10
            //Output: "The middle value is: 15"
            Console.WriteLine(Middle(100, 3, 40));












        }
    }
}
