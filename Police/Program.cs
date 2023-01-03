using System;
using System.Text;
using System.Xml.Linq;

namespace Police
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.Write("Enter the number of officers: ");
            int arrSize = int.Parse(Console.ReadLine());
            Officer[] district99 = new Officer[arrSize];
            Console.WriteLine();

            for (int i = 0; i < arrSize; i++)
            {
                Console.Write("Enter details for officer " + (i+1) + "\nName: ");
                string name = Console.ReadLine();

                Console.Write("Surname: ");
                string surname = Console.ReadLine();

                Console.Write("OfficerID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Working district: ");
                string district = Console.ReadLine();

                Console.Write("Number of crimes solved: ");
                int crimesSolved = int.Parse(Console.ReadLine());

                Console.WriteLine();

                Officer officer = new Officer(name, surname, id, district, crimesSolved);

                district99[i] = officer;

            }

            //Console.WriteLine(String.Format("Officers details: \nName\t\tSurname\t\tOfficerID\t\tWorking district\t\tCrimes solved"));

            //Console.WriteLine(String.Format("|{0,5}|{1,5}|{2,5}|{3,5}|{4,5}|",Name,Surname,OfficerID,Working district,Crimes solved"));

            Console.WriteLine(String.Format("|{0,-20|{1,-20}|{2,-10}|{3,-20}|{4,-10}|", "NAME", "SURNAME", "ID", "WORKING DISTRICT", "CRIMES SOLVED"));

            foreach (var item in district99)
            {
                Console.WriteLine(item.OfficerDetails());
            }

            Console.WriteLine("Number of level 1 officers: " + Officer.Level1Amount(district99));
            Console.WriteLine("Number of high level officers: " + (district99.Length - Officer.Level1Amount(district99)));

            // Find officer by name
            Console.Write("\nFind officer by name: ");
            string findName = Console.ReadLine();
            Officer.FindName(district99, findName);


        }
    }
}
