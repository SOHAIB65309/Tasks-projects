using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAb7
{
    class kiet { }
    class Emp : kiet
    {
        int id;
        string desg;
        int salary;
        public  void empshow()
        {
            Console.WriteLine("emp class");
        }
        public Emp() { Console.WriteLine("bhag yahan sa"); }
    }
   
    
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
