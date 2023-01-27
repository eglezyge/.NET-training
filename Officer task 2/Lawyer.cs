using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Officer_task_2
{
    public class Lawyer : Person
    {
        private int LawyerID { get; set; }
        private int HelpedInCrimesSolved { get; set; }
        public Lawyer() { }
        public Lawyer(string name, string surname, int lawyerID, int helpedInCrimesSolved):base(name, surname)
        {
            LawyerID = lawyerID;
            HelpedInCrimesSolved = helpedInCrimesSolved;
        }
        public override string ToString()
        {
            string details = "Lawyer ID: " + LawyerID + " ; " + "Helped in crimes solved: " + HelpedInCrimesSolved + "\n";
            return base.ToString() + details;
        }
    }
}
