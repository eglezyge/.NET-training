using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Student : Person
    {
        //private string universityName;
        //public string UniversityName 
        //{ 
        //get { return universityName; }
        //set { universityName = value; }
        //}
        public string University { get; set; }

        public Student(string universityName, string firstName, string lastName) : base(firstName, lastName)
        {
            this.University = universityName;
        }
    }
}
