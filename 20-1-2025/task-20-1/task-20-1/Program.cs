using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Claims;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace task_20_1
{

    internal class Program
    {
        public static void numberCheck(int x)
        {

            if (x % 2 == 0)
            {
                Console.WriteLine("The number " + x + " is even.");
            }
            else
            {
                Console.WriteLine("The number " + x + " is odd.");
            }
        }

        public static void five(int[] num)
        {
            Array.Sort(num);
            Console.WriteLine(num[1]);
        }
        public static int factorial(int n)
        {
            int count = 1;
            for (int i = 1; i <= n; i++)
            {
                count = count * i;
            }
            return count;
        }
        //public static int IsPrime(int x, int y)
        //{
        //    //if (num === 1)
        //    //{
        //    //    return false;
        //    //}
        //    //else
        //    //{
        //    //    for (var i = 2; i < num; i++)
        //    //    {
        //    //        if (num % i === 0)
        //    //        {
        //    //            return false;
        //    //        }
        //    //    }
        //    //    return true;
        //    }
        //}
        static void PrintPrimesBetween(int start, int end)
        {
            Console.WriteLine($"Prime numbers between {start} and {end}:");

            for (int num = start; num <= end; num++)
            {
                bool isPrime = true;

                if (num < 2) isPrime = false;
                else
                {
                    for (int i = 2; i <= num - 1; i++)
                    {
                        if (num % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }

                if (isPrime)
                {
                    Console.Write($"{num}, ");
                }
            }

            Console.WriteLine();
        }
        public static void jana()
        {
            bool b = false;
            int x = 25;
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    b = false;
                    break;
                }
                else
                {

                    b= true;

                }
            }
            if (b)
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            }

        }
        public static void pattern(int x)
        {
            int count = 1;
            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= count; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
                count++;
            }
        }
        //my sol.
        class Room1
        {
            const string HotelName1 = "Grand Stay Hotel";
            static string RoomNumber1;
            static string[] RoomType1 = { "Single", "Double", "Suite" };
            static string[] PricePerNight1 = { "Single:100JD", "Double:200JD", "Suite:300JD" };
            static string[] IsBooked1 = { "Available", "Not Available" };
        }
        //vhat gpt sol.
        class Room
        {
            const string HotelName = "Grand Stay Hotel";
            public string RoomNumber;
            public string RoomType;
            public double PricePerNight;
            public bool IsBooked;

            // Single method to input room details and book a room
            public static void ManageRoomBooking()
            {
                // Create an array to store rooms
                Room[] rooms = new Room[2];
                rooms[0] = new Room { RoomNumber = "101", RoomType = "Single", PricePerNight = 100, IsBooked = false };
                rooms[1] = new Room { RoomNumber = "102", RoomType = "Double", PricePerNight = 200, IsBooked = false };

                // Display room details
                foreach (var room in rooms)
                {
                    Console.WriteLine($"Room Number: {room.RoomNumber}");
                    Console.WriteLine($"Room Type: {room.RoomType}");
                    Console.WriteLine($"Price Per Night: {room.PricePerNight} JD");
                    Console.WriteLine($"Booking Status: {(room.IsBooked ? "Not Available" : "Available")}");
                    Console.WriteLine();
                }

                // Ask the user to book a room
                Console.WriteLine("Enter room number to book: ");
                string roomToBook = Console.ReadLine();

                // Check and book the room
                bool roomFound = false;
                foreach (var room in rooms)
                {
                    if (room.RoomNumber == roomToBook)
                    {
                        roomFound = true;
                        if (room.IsBooked)
                        {
                            Console.WriteLine("This room is already booked.");
                        }
                        else
                        {
                            room.IsBooked = true;
                            Console.WriteLine($"Room {room.RoomNumber} has been booked.");
                        }
                        break;
                    }
                }

                // If the room number is invalid
                if (!roomFound)
                {
                    Console.WriteLine("Invalid room number.");
                }

                // Display updated room details
                Console.WriteLine("\nUpdated Room Information:");
                foreach (var room in rooms)
                {
                    Console.WriteLine($"Room Number: {room.RoomNumber}");
                    Console.WriteLine($"Room Type: {room.RoomType}");
                    Console.WriteLine($"Price Per Night: {room.PricePerNight} JD");
                    Console.WriteLine($"Booking Status: {(room.IsBooked ? "Not Available" : "Available")}");
                    Console.WriteLine();
                }
            }
            static void Main(string[] args)
            {
                //1 - Write a C# program that accepts an integer and determines 
                //    if the number is even or odd. Display the result.
                numberCheck(7);

                //2 - Write a C# program that accepts five numbers and
                //    displays the  2nd smallest of the five.
                //    •	Example Input: 4, -3, 7, 2, 0
                //    •	Output: 0
                int[] nums = { 8, 9, 6, 2, 7 };
                five(nums);

                //3 - Write a program that calculates the factorial of a given number using a for loop.
                //    •	Example Input: 5
                //    •	Output: 120(5 × 4 × 3 × 2 × 1 = 120)
                Console.WriteLine(factorial(5));

                //4 - Write a program that takes two integers as input and prints all the prime numbers between
                //them using nested loops.
                //    •	Example Input:
                //    o Start: 10
                //    o End: 30
                //    Output: 11, 13, 17, 19, 23, 29
                PrintPrimesBetween(10, 30);

                //5 - Create a program that initializes an integer array and finds
                //    the largest number in it using a foreach loop.
                //    •	Example Array: { 3, 1, 4, 1, 5, 9}
                //    •	Output: 9
                int[] numbers = { 3, 1, 4, 1, 5, 9 };
                int largest = numbers[0];
                foreach (var item in numbers)
                {
                    if (item > largest)
                    {
                        largest = item;
                    }
                    else
                    {
                    }
                }
                Console.WriteLine("largest number is : " + largest);

                //6 - Write a program that prints the following number pattern using nested loops:
                //    For n = 5, the output should be:
                //    1
                //    2 3
                //    4 5 6
                //    7 8 9 10
                //    11 12 13 14 15
                pattern(7);

                //Class && Object
                //Create a Hotel Reservation System where the program manages room bookings for a hotel. Each room has the following properties:
                //    •	Room Number
                //    •	Room Type(e.g., Single, Double, Suite)
                //    •	Price Per Night
                //    •	IsBooked(whether the room is already booked or not)
                //    •	HotelName = "Grand Stay Hotel";   as constant
                //    You need to:
                //    1.Create a class Room with appropriate properties.
                //    2.Allow the user to input details for at least 2 rooms.
                Room.ManageRoomBooking();

                jana();






            }
        }
    }
}
