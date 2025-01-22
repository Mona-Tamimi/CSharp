using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5_22_1_2025
{
    internal class Program
    {
        class Vehicle
        {
            public string Brand  { get; set; }
            public string Model   { get; set; }

            public void Start()
            {
                Console.WriteLine("Vehicle is starting");
            }
        }

        class Car : Vehicle
        {
            public int NumberOfDoors { get; set; }

            public void print()
            {
                Console.WriteLine($"The brand of the vehicle: {Brand}, The model of the vehicle: {Model}, The number of doors in the car: {NumberOfDoors}");
            }

        }
        static void Main(string[] args)
        {
            Vehicle v = new Car();
            Car car = new Car();
            car.Brand = "brand";
            car.Model = "model";
            car.NumberOfDoors = 2;
            car.print();

        //Constructor: A method that initializes an object when it's created.
        //OOP Concepts: Encapsulation, Inheritance, Polymorphism, and Abstraction.
        //Encapsulation: Protecting data by controlling access using methods or properties.
        //Sealed Class: A class that cannot be inherited.
        //Inheritance: A child class using the properties and methods of a parent class.
            
        }
    }
}
