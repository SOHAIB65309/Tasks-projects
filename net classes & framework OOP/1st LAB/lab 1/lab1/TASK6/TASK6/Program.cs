using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LabTask6
{
    class LandTransport
    {
        public string Model { get; set; }
        public int Wheels { get; set; }
        public int doors { get; set; }
        public int Speed { get; set; }
        public int capacity { get; set; }
    }
    class car : LandTransport
    {
        public string BodyType { get; set; }
        public int EngineSize { get; set; }
        public bool AC { get; set; }
    }
    class bus : LandTransport
    {
        public int Seats { get; set; }
        public int Standing { get; set; }
        public bool Ramp { get; set; }
    }
    class Truck : LandTransport
    {
        public int Capacity { get; set; }
        public int Axles { get; set; }
        public bool SleeperCab { get; set; }
    }
    class bicycle : LandTransport
    {
        public int Gears { get; set; }
        public bool Bell { get; set; }
        public bool reflectors { get; set; }
    }

    class Human
    {
        public string name;
        public char gender;
        public int age;
        public Human(string n, char g, int a)
        {
            name = n;
            gender = g;
            age = a;
        }
        public void show()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Age: " + age);
        }
    }
    class student : Human
    {
        public string PreviousEducation;
        public string CurrentEducation;
        public float PreviousCGPA;
        public float CurrentCGPA;
        public student(string pe, string ce, float pcgpa, float ccgpa) : base("Bangash", 'M', 22)
        {

            PreviousEducation = pe;
            CurrentEducation = ce;
            PreviousCGPA = pcgpa;
            CurrentCGPA = ccgpa;
        }
        public void Sshow()
        {
            Console.WriteLine("Previous Education: " + PreviousEducation);
            Console.WriteLine("Current Education: " + CurrentEducation);
            Console.WriteLine("Previous CGPA: " + PreviousCGPA);
            Console.WriteLine("Current CGPA: " + CurrentCGPA);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            car c1 = new car();
            c1.BodyType = "big";
            c1.AC = true;
            c1.capacity = 8;
            c1.doors = 6;
            c1.EngineSize = 4800;
            c1.Model = "Corola";
            c1.Speed = 220;
            c1.Wheels = 6;
            Console.WriteLine(" Body Type is : " + c1.BodyType + "\n" + " It has AC or Not: " + c1.AC + "\n" + " Capcity is : " + c1.capacity + "\n" + " Doors are: " + c1.doors + "\n" + " Engine Size is " + c1.EngineSize + " Model is : " + c1.Model + "\n" + " Speed and Wheels are : " + c1.Speed +
                " and " + c1.Wheels);

            Human h1 = new Human("Sohiab", 'M', 21);
            h1.show();


        }
    }
}