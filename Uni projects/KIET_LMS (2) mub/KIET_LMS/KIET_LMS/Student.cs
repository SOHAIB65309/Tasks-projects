using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIET_LMS
{
    internal static class Student
    {

        private static string _name;
        private static string _email;
        private static int _age;
        private static string _DegreeProgram;
        private static long _CNIC;
        private static long _cellNo;
        private static string _gender;
        private static string _Password;
        private static int _crHourLimit;
        private static int _SID;
        public static double CGPA;

        public static string name 
        {
            get { return _name; }
            set { _name = value; }
        }

        public static string email 
        {
            get { return _email; }
            set { _email = value; }
        }

        public static string DegreeProgram
        {
            get { return _DegreeProgram; }
            set { _DegreeProgram = value; }
        }

        public static string gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public static string Password
        {
            get { return _Password; }
            set { Password = value; }
        }
        public static int age
        {
            get { return _age; }
            set { _age = value; }
        }

        public static int SID
        {
            get { return _SID; }
            set { _SID = value; }
        }

        public static int crHourLimit
        {
            get { return _crHourLimit; }
            set { _crHourLimit = value; }
        }

        public static long CNIC 
        {
            get { return _CNIC; }
            set { _CNIC = value; }
        }

        public static long cellNo
        {
            get { return _cellNo; }
            set { _cellNo = value; }
        }









    }
}
