using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12_13
{
    //public abstract class network
    //{
    //    public abstract void switch1();
    //    public abstract void router();
    //}
    //public class stfiber : network
    //{
    //    public override void switch1()
    //    {
    //        Console.WriteLine("switch");
    //    }
    //    public override void router()
    //    {
    //        Console.WriteLine("router");
    //    }
    public abstract class Book
    {
        public abstract void books(string  Bname, string author,double Price, int qty= 0);

    }
    class  bookDetail : Book
    {
        public override void books(string Bname, string author, double Price, int qty)
        {
            Console.WriteLine("Book Name: "+Bname+"Book Author: "+author+"Price: "+Price+"Qty: "+qty);
        }
    }
   public  abstract class travel
    {
        public abstract void ModeOfTravel();
        public void refuil()
        {

            Console.WriteLine("REfuil completed");
        }
    }
    class Boat : travel
    {
        public override void ModeOfTravel()
        {
            Console.WriteLine("Mode of travel of boad (sea,lakes)");
        }
    }
    class Car : travel
    {
        public override void ModeOfTravel()
        {
            Console.WriteLine("Mode of travel roads( streats )");
        }
    }
    class airplane: travel
    {
        public override void ModeOfTravel()
        {
            Console.WriteLine("Mode of travel (Air)");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 1");
            bookDetail b1 = new bookDetail();
            b1.books("habits", "hoby", 500, 20);
            Console.WriteLine("Question 2");
            Car c = new Car();
            c.ModeOfTravel();
            c.refuil();
            airplane a = new airplane();
            a.ModeOfTravel();
            a.refuil();
            Boat b = new Boat();
            b.ModeOfTravel();
            b.refuil();
        }
    }
}
