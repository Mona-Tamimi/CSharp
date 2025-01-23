using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6_23_1_2025
{
    internal class Program
    {
        class Calculator
        {
            public int add(int a, int b)
            {
                return a + b;
            }
            public int add(int a, int b, int c)
            {
                return a + b + c;
            }
            public double add(double a, double b)
            {
                return a + b;
            }
        }
        class Shape
            {
                public virtual void draw()
                {
                    Console.WriteLine("drawing");
                }
            }
        class Circle : Shape
        {
            public override void draw()
            {
                Console.WriteLine("Drawing a Circle");
            }
        }
        class Rectangle  : Shape
        {
            public override void draw()
            {
                Console.WriteLine("Drawing a Rectangle ");
            }
        }
         abstract class Animal
        {
            public abstract void makeSound();
        }
        class Dog : Animal
        {
            public override void makeSound() {
                Console.WriteLine("Dog barks.");
            }
        }
        class Cat : Animal
        {
            public override void makeSound()
            {
                Console.WriteLine("Cat meows.");
            }
        }
        interface IPlayable
        {
            void play();
        }

        class Piano : IPlayable
        {
            public void play()
            {
                Console.WriteLine("Playing the piano.");
            }
        }
        class Guitar : IPlayable
        {
            public void play()
            {
                Console.WriteLine("Playing the guitar.");
            }
        }

        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.add(2, 5);
            calculator.add(2, 5,3);
            calculator.add(2.2, 5.11);

            Shape shape = new Shape();
            Shape circle = new Circle();
            circle.draw();
            Shape rect = new Rectangle();
            rect.draw();

            Animal dog = new Dog();
            dog.makeSound();
            Animal cat = new Cat();
            cat.makeSound();

            Guitar guitar = new Guitar();
            guitar.play();
            Piano piano = new Piano();  
            piano.play();



        }
    }
}
