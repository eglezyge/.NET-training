using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police
{
    public class Officer
    {
        private string OfficerName { get; set; }
        private string OfficerSurname { get; set; }
        private int OfficerID { get; set; }
        private string OfficerDistrict { get; set; }
        private int OfficerCrimesSolved { get; set; }

        public Officer() 
        {
        }

        public Officer(string name, string surname, int id, string district, int crimesSolved)
        {
            OfficerName = name;
            OfficerSurname = surname;
            OfficerID = id;
            OfficerDistrict = district;
            OfficerCrimesSolved = crimesSolved;
        }

        public string OfficerDetails()
        {
            //return String.Format("|{0,-20|{1,-20}|{2,-10}|{3,-20}|{4,-10}|", OfficerName, OfficerSurname, OfficerID, OfficerDistrict, OfficerCrimesSolved);
            return OfficerName + "\t\t" + OfficerSurname + "\t\t\t" + OfficerID + "\t\t" + OfficerDistrict + "\t\t" + OfficerCrimesSolved;
        }

        public int CalculatedLevel()
        {
            if (OfficerCrimesSolved < 20)
            {
                return 1;
            }
            else if (OfficerCrimesSolved >= 20 && OfficerCrimesSolved < 40)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }

        public static int Level1Amount(Officer[] array)
        {
            int level1 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].CalculatedLevel() == 1)
                {
                    level1++;
                }
            }
            return level1;
        }

        public static void FindName(Officer[] array, string name)
        {
            bool nameNotFound = true;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].OfficerName == name)
                {
                    Console.WriteLine("There is an officer named " + name);
                    nameNotFound = false;
                    break;
                }
            }
            if (nameNotFound)
            {
                Console.WriteLine("There is no officer named " + name);
            }
         }
    }
}
