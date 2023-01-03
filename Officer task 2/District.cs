using System;
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
        private Officer[] OfficersInTheDistrict { get; set; }

        public District() { }

        public District(string title, string city, int districtID, Officer[] officersInDistrict) 
        {
            DistrictTitle = title;
            DistrictCity = city;
            DistrictID = districtID;
            OfficersInTheDistrict= officersInDistrict;
        }

    }
}
