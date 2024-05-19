using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG261_Project
{
    internal class Student
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string DOB { get; set; }
        public int phone { get; set; }
        public string courseID { get; set; }
        public string gender { get; set; }
        public string address { get; set; }
        public string studentID { get; set; }

        //default constructor
        public Student() { }

        //constructor
        public Student (string n, string s, string d, int p, string c, string g, string a, string si)
        {
            this.name = n;
            this.surname = s;
            this.DOB = d;
            this.phone = p;
            this.courseID = c;
            this.gender = g;   
            this.address = a;
            this.studentID = si;
        }
    }
}
