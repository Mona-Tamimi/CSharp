using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace optional_task_16_1_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Define an array named fruits that holds more than 5 different types of fruits. 
            //    Then, print each fruit along with its index in the array, followed by the total 
            //    number of fruits in the array.
            string[] fruits = { "Apple", "Mango", "Banana", "Orange", "Berry" };
            Console.WriteLine("fruit at index 0 is : " + fruits[0]);
            Console.WriteLine("fruit at index 1 is : " + fruits[1]);
            Console.WriteLine("fruit at index 2 is : " + fruits[2]);
            Console.WriteLine("fruit at index 3 is : " + fruits[3]);
            Console.WriteLine("fruit at index 4 is : " + fruits[4]);
            Console.WriteLine("Total number of fruits : " + fruits.Length);

            //2 - Write a program in C# to store 5 integers in an array. Then, 
            //    reverse the order of the elements and print both the original and reversed arrays.
            //    HINT : Convert.ToInt32(console.ReadLine())
            string[] numbers = new string[5];
            Console.WriteLine("Input 5 numbers into the array: ");
            Console.WriteLine("number at index 0 is : ");
            numbers[0] = Console.ReadLine();
            Console.WriteLine("number at index 1 is : ");
            numbers[1] = Console.ReadLine();
            Console.WriteLine("number at index 2 is : ");
            numbers[2] = Console.ReadLine();
            Console.WriteLine("number at index 3 is : ");
            numbers[3] = Console.ReadLine();
            Console.WriteLine("number at index 4 is : ");
            numbers[4] = Console.ReadLine();

            Console.WriteLine("Original Array: " + numbers[0] + " " + numbers[1] + " " + numbers[2] + " " + numbers[3] + " " + numbers[4]);
            Console.WriteLine("Original Array: " + numbers[4] + " " + numbers[3] + " " + numbers[2] + " " + numbers[1] + " " + numbers[0]);

            //3 - Write a program in C# to define an array of strings representing different colors. 
            //    Then, count and display how many colors start with the letter "R" (case insensitive).
            string[] colors = { "red", "blue", "Rose", "black", "ruby" };
            int count = 0;
            Console.WriteLine("Colors starting with 'R':");
            foreach (string color in colors)
            {

                if (!string.IsNullOrEmpty(color) && char.ToLower(color[0]) == 'r')
                {
                    Console.WriteLine(color);
                    count++;
                }
            }

            Console.WriteLine($"\nTotal number of colors that start with 'R': {count}");


            //4 - Sum , sort , min , max and Average of Array Elements
            //    Hint: using Convert.ToInt32(console.ReadLine())
            string[] nums = new string[6];
            Console.WriteLine("Input 6 numbers into the array: ");
            Console.WriteLine("number at index 0 is : ");
            nums[0] = Console.ReadLine();
            Console.WriteLine("number at index 1 is : ");
            nums[1] = Console.ReadLine();
            Console.WriteLine("number at index 2 is : ");
            nums[2] = Console.ReadLine();
            Console.WriteLine("number at index 3 is : ");
            nums[3] = Console.ReadLine();
            Console.WriteLine("number at index 4 is : ");
            nums[4] = Console.ReadLine();
            Console.WriteLine("number at index 5 is : ");
            nums[5] = Console.ReadLine();

            int sum = 0;
            int min = int.Parse(nums[0]);
            int max = int.Parse(nums[0]);
            foreach (string num in nums)
            {
                sum += int.Parse(num);
                if (min > int.Parse(num))
                {
                    min = int.Parse(num);
                }
                if (max < int.Parse(num))
                {
                    max = int.Parse(num);
                }
            }
            double avg = sum / nums.Length;
            Console.WriteLine("Sum of numbers = " + sum);
            Console.WriteLine("Average of numbers = " + avg);
            Console.WriteLine("min = " + min);
            Console.WriteLine("max = " + max);
            Console.WriteLine("sort : ");

            Array.Sort(nums);
            foreach (string i in nums)
            {
                Console.Write(i);
            }
            Console.WriteLine();
            //Console.WriteLine("Sum of numbers = " + nums.Sum());
            Console.WriteLine("min of numbers = " + nums.Min());
            Console.WriteLine("max of numbers = " + nums.Max());












        }
    }
}
