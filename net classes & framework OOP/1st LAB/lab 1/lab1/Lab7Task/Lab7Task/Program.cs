using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Task
{
    public class Engine
    {
        int cc;
        int horsepower;
        public Engine(int c, int hp)
        {
            cc = c;
            horsepower = hp;
        }
        public void engine_details()
        {
            Console.WriteLine("Engine type:  {0} \nhorse power: {1} ", cc, horsepower);
        }
    }
    public class Wheel : Engine
    {
        int numbers;
        string type;
        public Wheel(int no, string t, int c, int h1)
            : base(c, h1)
        {
            numbers = no;
            type = t;
        }
        public void wheels_details()
        {
            Console.WriteLine("Number of wheels: {0}  \nWheel type is : {1}", numbers, type);
        }
    }
    public class Car : Wheel
    {
        int modelno;
        public Car(int model, int no, string ty, int c, int h)
            : base(no, ty, c, h)
        {
            modelno = model;
        }

        public void car_details()
        {
            Console.WriteLine("The model of car is: " + modelno);
            engine_details();
            wheels_details();

        }
    }
  //**************************************************************************//
        public class HRManager
        {
            public string Name { get; private set; }

            public HRManager(string name)
            {
                this.Name = name;
            }

            public void HireEmployee(Contract contract)
            {
                Console.WriteLine("Employee with contract type {0} has been hired on {1}.", contract.ContractType, contract.StartDate.ToShortDateString());
            }

            public void TerminateEmployee(Contract contract)
            {
                Console.WriteLine("Employee with contract type {0} has been terminated.", contract.ContractType);
            }
        }

        public class Contract
        {
            public DateTime StartDate;
            public string ContractType;

            public Contract(DateTime startDate, string contractType)
            {
                this.StartDate = startDate;
                this.ContractType = contractType;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Car car1 = new Car(2023, 8, "Heavy", 8000, 5500);
            car1.car_details();
            HRManager hrManager = new HRManager("Sohaib Anjum");
            Console.WriteLine("**********PART B*******");
            Contract contract = new Contract(DateTime.Today, "half-Time");
            hrManager.HireEmployee(contract);
            Console.WriteLine("Employee start date: {0}", contract.StartDate);
            Console.WriteLine("Employee contract type: {0}", contract.ContractType);
            hrManager.TerminateEmployee(contract);
            Console.WriteLine("Employee has been terminated.");
            Console.WriteLine("***********PART c********");
            Human human = new Human();
            human.Walk();
            LeftHand leftHand = new LeftHand();
            leftHand.Move();
            RightLeg rightLeg = new RightLeg();
            rightLeg.Move();
        }
        }
        public class Human
        {
            private Hand hand;
            private Leg leg;

            public Human()
            {
                hand = new Hand();
                leg = new Leg();
            }

            public void Walk()
            {
                leg.Move();
            }
        }
        public class Hand
        {
            public virtual void Move()
            {
                Console.WriteLine("The hand moving");
            }
        }
        public class LeftHand : Hand
        {
            public override void Move()
            {
                Console.WriteLine("The left hand is moving up");
            }
        }
        public class RightHand : Hand
        {
            public override void Move()
            {
                Console.WriteLine("The right hand is moving.");
            }
        }
        public class Leg
        {
            public virtual void Move()
            {
                Console.WriteLine("The leg is moving.");
            }
        }
        public class LeftLeg : Leg
        {
            public override void Move()
            {
                Console.WriteLine("The left leg is moving");
            }
        }
        public class RightLeg : Leg
        {
            public override void Move()
            {
                Console.WriteLine("The right leg is moving");
            }
        }
    }

    



