using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Officer_task_2
{
    public class District
    {
        private string DistrictTitle { get; set; }
        private string DistrictCity { get; set;}
        private int DistrictID { get; set; }

        private List<Officer> officersInDistrict; //generic type 
        //private ArrayList officersInDistrict;
        //private Officer[] OfficersInTheDistrict { get; set; }

        public District() 
        {
            officersInDistrict = new List<Officer>();
        }

        public District(string title, string city, int districtID)
        {
            DistrictTitle = title;
            DistrictCity = city;
            DistrictID = districtID;
            officersInDistrict = new List<Officer>();
        }

        public override string ToString()
        {
            string details = "District name: " + DistrictTitle + " ; " + "City: " + DistrictCity + " ; " + "ID: " + DistrictID + officersInDistrict.Count + "\n";
            return details;
            //return base.ToString() + details;
        }

        //public bool AddNewOfficer(Officer officer)
        //{
        //    officersInDistrict.Add(officer);
        //    return true;
        //}

        public void AddNewOfficer(Officer officer)
        {
            officersInDistrict.Add(officer);
        }

        //public bool RemoveOfficer(Officer officer)
        //{
        //    officersInDistrict.Remove(officer);//removes a specific officer from the list
        //    return true;   
        //}

        public void RemoveOfficer(Officer officer)
        {
            officersInDistrict.Remove(officer);//removes a specific officer from the list
        }

        public void PrintAllOfficers()
        {
            foreach (var officer in officersInDistrict)
            Console.WriteLine(officer);
        }
    }
}
