using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{

    class Product
    {
        static int Product_id;
        static double Price;
         public Product()
        {
            Product_id =5546;
            Price = 1499;
        }

        public static void Display()
        {
            Console.WriteLine("Product Id{0}\t{1}",Product_id,Price);
        }
    }
  public  class Claculate
    {
       public static int n1=2;
        public static int n2=10;
        public static int tot;
        public static void Addition()
        {
            tot=n1 + n2;
            Console.WriteLine(  "this is addition  "+tot );
        }
    }
    class StaticMethod
    {
        static void Main(string[] args)
        {
            Product pro = new Product();
            Product.Display();
            Claculate cal = new Claculate();
            Claculate.Addition();
            
        }


    }
    class Program
    {

    }
}
