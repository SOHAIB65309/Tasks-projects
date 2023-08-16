using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_Task_3
{
    class author
    {
        string name = "Sohaib";
        string email = "Sohiab@gmail.com";
        string gender = "Male";
        public author()
        {
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter email:");
            email = Console.ReadLine();
            Console.WriteLine("Enter Gender:");
            gender = Console.ReadLine();

        }
        public void show3()
        {
            Console.WriteLine("*************");
            Console.WriteLine("Name is:" + name);
            Console.WriteLine("Email is:" + email);
            Console.WriteLine("Gender is:" + gender);
        }
    }
    class circle
    {
        double radius = 5;
        string color = "Blue";
        public circle()
        {
            Console.WriteLine("Enter Radius:");
            radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Color:");
            color = Console.ReadLine();

        }
        public void show()
        {
            Console.WriteLine("Radius is:" + radius);
            Console.WriteLine("Color is:" + color);
            Console.WriteLine("**************************");
        }
    }
    class rectangle
    {
        double length = 1;
        double width = 1;
        public rectangle()
        {
            Console.WriteLine("Enter Length:");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Width:");
            width = Convert.ToInt32(Console.ReadLine());
        }
        public void show2()
        {
            Console.WriteLine("Length is:" + length);
            Console.WriteLine("Width is:" + width);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            circle c1 = new circle();
            c1.show();

            rectangle r1 = new rectangle();
            r1.show2();

            author a1 = new author();
            a1.show3();
        }
    }
}
