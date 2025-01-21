using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace ConsoleApp1
{
    internal class Program
    {
        class Student
        {
            public string Name { get; set; } //property
            public int Age { get; set; } //property
            public int StudentID { get; set; } //property
            public int Email { get; set; } //property

            public const int MinAge = 18; //constant
            public const int MaxAge = 40; //constant

            public void GetDetails()
            {
                Console.WriteLine($"Student Name: {Name}, Age: {Age}, {StudentID}");
            }
            public Student()
            {
                Name = "";
                Age = MinAge;
                StudentID = 1;
            }
             public Student(string name, int age, int id)
            {
                Name = name;
                Age = age;
                StudentID = id;
            }
            ~Student()
            {
                Console.WriteLine("finish");
            }

        }
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Name = "Ahmad";
            student1.Age = 22;
            student1.StudentID = 1001;
            student1.GetDetails();
            
            Student student2 = new Student("Mona",23,2001);
            student2.GetDetails();
            Student student3 = new Student("Nada", 22, 2002);
            student3.GetDetails();

            //1. * *What is class?**  
            //   A class is a blueprint for creating objects, defining their properties and methods.

            //2. **What is object?**
            //   An object is an instance of a class, containing data and behavior defined by the class.

            //3. **Difference between class && object**
            //   A class is a template, while an object is a specific instance of that template.

            //4. **Mention the OOP Principles**  
            //   - Encapsulation
            //   - Inheritance
            //   - Polymorphism
            //   - Abstraction

            //5. **What is property?**
            //   A property is a special method in a class used to get or set the value of a field.

            //6. **What is field?**
            //   A field is a variable declared in a class to store data.

            //7. **What is constructor?**
            //   A constructor is a special method in a class that initializes objects when they are created.

            //8. **What is encapsulation?**
            //   Encapsulation is restricting access to data by bundling it with methods, ensuring controlled interaction.
        }

    }
}
