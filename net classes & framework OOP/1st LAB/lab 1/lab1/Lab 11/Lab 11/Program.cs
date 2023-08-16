using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class Human
    {
        public double T_Distance;
        public double t_distance1;
        public Human(double Td, double td)
        {
            T_Distance = Td;
            t_distance1 = td;
        }
        public void WALK(int distance)
        {
            T_Distance += distance;
            Console.WriteLine(T_Distance);
        }
        public void WALK(string distance)
        {
            T_Distance += Convert.ToDouble(distance);
            Console.WriteLine(T_Distance);
        }
        public void WALK(float distance)
        {
            T_Distance += Convert.ToDouble(distance);
            Console.WriteLine(T_Distance);
        }
        public void RUN(int distance)
        {
            t_distance1 += distance;
            Console.WriteLine(t_distance1);
        }
        public void RUN(string distance)
        {
            t_distance1 += Convert.ToDouble(distance);
            Console.WriteLine(t_distance1);
        }
        public void RUN(float distance)
        {
            t_distance1 += Convert.ToDouble(distance);
            Console.WriteLine(t_distance1);
        }
    }
    //"============================================"
    class Train
    {
        public string Source, Destination;
        public virtual void EngineWork(string Source, string
        Destination)
        {
            this.Source = Source;
            this.Destination = Destination;
            Console.WriteLine("\tSource of Train: " + Source +
            "\tDestination of Train " + Destination);
        }
    }
    class ReverseTrain : Train
    {
        public override void EngineWork(string Source, string Destination)
        {
            this.Source = Source;
            this.Destination = Destination;
            Console.WriteLine("\tSource of Train: " + Source + "\tDestination of Train " + Destination);
        }
    }
    class Train1
    {
        public string Source, Destination;
        public virtual void Enginework1(string Source, string Destination)
        {
            this.Source = Source; this.Destination = Destination;
            Console.WriteLine("\tSource of Train: " + Source +
            "\tDestination of Train " + Destination);
        }
    }
    class ReverseTrain1 : Train1
    {
        public void Enginework1(string Source, string Destination, string JourneyTime)
        {
            this.Source = Source; this.Destination = Destination;
            Console.WriteLine("\tSource of Train: " + Source + "\tDestination of Train " + Destination + "\t Journey time  is: " + JourneyTime);
        }
    }
        class Program
        {

            static void Main(string[] args)
            {
                Human wnr = new Human(0, 0);
                Console.WriteLine("================== ");
                Console.WriteLine("\tWalking");
            Console.WriteLine("Enter walk 1");
            int w1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter walk 2");
            float w2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter walk 3");
            string w3 = Console.ReadLine();
            wnr.WALK(w1);
            wnr.WALK(w2);
            wnr.WALK(w2);
                Console.WriteLine("\tRuning");
            Console.WriteLine("Enter run1");
            string r1 = Console.ReadLine();
            Console.WriteLine("Enter run1");
            float r2 =int.Parse( Console.ReadLine());
            Console.WriteLine("Enter run1");
            int r3 =int.Parse( Console.ReadLine());
            Console.WriteLine("==================\n");
               wnr.RUN(r1);
               wnr.RUN(r2);
               wnr.RUN(r3);
               Console.WriteLine("=======QUESTION 2===========");
               Train train1 = new Train();
               ReverseTrain reverse2 = new ReverseTrain();
            Console.WriteLine("Enter source 1 train");
            string s1t = Console.ReadLine();
            Console.WriteLine("Enter destination 1 train");
            string d1t = Console.ReadLine();
            train1.EngineWork(s1t, d1t);
            Console.WriteLine("Enter source 1 engine");
            string s1e = Console.ReadLine();
            Console.WriteLine("Enter destination 1 engine");
            string d1e = Console.ReadLine();
            train1.EngineWork(s1t, d1t);
            reverse2.EngineWork(s1e, d1e);
               Console.WriteLine("===================================================================== ");
               Console.WriteLine("=======QUESTION 3============");
               Train1 Train2 = new Train1();
               ReverseTrain1 Reverse2 = new ReverseTrain1();
            Console.WriteLine("Enter source 1 train");
            string s2t = Console.ReadLine();
            Console.WriteLine("Enter destination 1 train");
            string s2d = Console.ReadLine();
               Train2.Enginework1(s2t, s2d);
             Console.WriteLine("3 input over load");
            Console.WriteLine("Enter source 2 train");
            string s3t = Console.ReadLine();
            Console.WriteLine("Enter destination 2 train");
            string s3d = Console.ReadLine();
            Console.WriteLine("Enter time in ");
            string s3ti = Console.ReadLine();
            Reverse2.Enginework1(s3t, s3d, s3ti);
            }
        }
    
}
