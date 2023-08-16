using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAb9
{
    class Algorithm
    {
        const  int threeshold = 150;
        public string  show (int value)
        {
            if (value < threeshold)
            {
                Console.WriteLine(value);
                return "not working \n";
            }

            Console.WriteLine(value);
                return "working \n";
            
        }
    }
    class UI:Algorithm
    {
        Algorithm al = new Algorithm();
        public  void ul(int value)
        {
            Console.WriteLine(al.show(value));
        }
    }
    //q2
    class father
    {
        protected int familymem;
        
    }
    class Son : father
    {
        public void familym(int value)
        {
            familymem = value;
            Console.WriteLine("family mem are :"+familymem);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Q1");
            UI obj1 = new UI();
            obj1.ul(200);
            UI obj2 = new UI();
            obj2.ul(50);
            Console.WriteLine("Q2");
            Son obj3 = new Son();
            obj3.familym(30);

        }
    }
}
