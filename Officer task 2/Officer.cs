﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Officer_task_2
{
    public class Officer : Person
    {
        //private string OfficerName { get; set; }
        //private string OfficerSurname { get; set; }
        private int OfficerID { get; set; }
        private int OfficerCrimesSolved { get; set; }

        public Officer(string name, string surname, int id, int crimesSolved):base(name, surname)
        {
            //OfficerName = name;
            //OfficerSurname = surname;
            OfficerID = id;
            OfficerCrimesSolved = crimesSolved;
        }

        //public string OfficerDetails()
        //{
        //    return OfficerName + "\t\t" + OfficerSurname + "\t\t\t" + OfficerID + "\t\t" + OfficerCrimesSolved;
        //}

        public override string ToString()
        {
            string details = "Officer ID: " + OfficerID + " ; " + "Crimes solved: " + OfficerCrimesSolved + "\n";
            return base.ToString() + details;
        }

        public Officer() { }

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

        //public static int Level1Amount(Officer[] array)
        //{
        //    int level1 = 0;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i].CalculatedLevel() == 1)
        //        {
        //            level1++;
        //        }
        //    }
        //    return level1;
        //}

        //public static void FindName(Officer[] array, string name)
        //{
        //    bool nameNotFound = true;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i].OfficerName == name)
        //        {
        //            Console.WriteLine("There is an officer named " + name);
        //            nameNotFound = false;
        //            break;
        //        }
        //    }
        //    if (nameNotFound)
        //    {
        //        Console.WriteLine("There is no officer named " + name);
        //    }
        //}
    }
}
