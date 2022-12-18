using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Person
    {
        //private string firstName, lastName;

        //public string FirstName
        //{
        //    get { return this.firstName; }
        //    set { this.firstName = value; }
        //}
        //public string LastName
        //{
        //    get { return this.lastName; }
        //    set { this.lastName = value; }
        //}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person (string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
