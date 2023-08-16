using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_Task_5
{
    class Student
    {
        public string name;
        public int age;
        public int admission_number;
        public string course;

        public Student(string name, int age, int admission_number, string course)
        {
            this.name = name;
            this.age = age;
            this.admission_number = admission_number;
            this.course = course;
            Console.WriteLine("Name is " + name + " , Age is : " + age + ", Admission number is : " + admission_number + " And Course is : " + course);
        }
    }
    class Programming
    {
        public string language;

        public Programming(string language = null)
        {
            if (language != null)
            {
                this.language = language;
                Console.WriteLine("I love " + language);
            }
            else
            {
                Console.WriteLine("I love programming languages");
            }
        }
    }

    class Rectangle
    {
        public int length;
        public int breadth;

        public Rectangle()
        {
            this.length = 0;
            this.breadth = 0;
            Console.WriteLine("Length: " + length + " Breadth : " + breadth);
        }

        public Rectangle(int length, int breadth)
        {
            this.length = length;
            this.breadth = breadth;
            Console.WriteLine("Length is " + length + " & Breadth is " + breadth);
        }

        public Rectangle(int size)
        {
            this.length = size;
            this.breadth = size;
            Console.WriteLine("Length is " + length + " & Breadth is " + breadth);
        }
    }
    class Area
    {
        public int length;
        public int breadth;
        public Area(int length2, int breadth2)
        {
            length = length2;
            breadth = breadth2;
        }
        public int returnArea()
        {
            Console.WriteLine("Area of rectangle is: " + length * breadth);
            return this.length * this.breadth;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {


            Rectangle r1 = new Rectangle(5);

            Student s1 = new Student("Sohaib", 80, 65309, "Obeject orented Language");

            Programming p1 = new Programming("C#");

            Area a1 = new Area(3, 4);
            a1.returnArea();

        }
    }
}
