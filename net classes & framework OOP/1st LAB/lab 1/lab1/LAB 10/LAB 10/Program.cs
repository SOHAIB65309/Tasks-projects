using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_mayyy_oop_aj
{
    class FaceBookAcc
    {
        private const string password = "Sohaib65309";
        bool login = false;
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (value == password)
                {
                    login = true;
                    Console.WriteLine("Login Successfully");
                }
                else
                {
                    Console.WriteLine("Please Enter Valid Password.");
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FaceBookAcc fbAccount = new FaceBookAcc();
            Console.WriteLine("Enter Password: ");
            string value = Console.ReadLine();
            fbAccount.Password = value;
        }
    }
}