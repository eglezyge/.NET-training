using System.Transactions;

namespace Officer_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Officer officer1 = new Officer("John", "Dutton",1, 100 );
            Officer officer2 = new Officer("Rebecca", "Bold", 2, 88);
            Officer officer3 = new Officer("Petras", "Aleksius", 3, 20);
            Officer officer4 = new Officer("Algis", "Arlauskas", 4, 145);
            Officer officer5 = new Officer("Onute", "Zableska", 5, 14);
            Officer officer6 = new Officer("Kiskis", "Ilgaausis", 6, 50);
            Officer officer7 = new Officer("Alisa", "Puiki", 7, 150);

            District district1 = new District("East", "Vilnius", 1);
            District district2 = new District("West", "Klaipeda", 2);

            Lawyer laywer1 = new Lawyer("Jhonny", "Pup", 01, 14);
            Lawyer lawyer2 = new Lawyer("Anny", "Ann", 02, 55);
            Lawyer lawyer3 = new Lawyer("Vaiva", "Boom", 03, 100);

            district1.AddNewOfficer(officer1);
            district1.AddNewOfficer(officer2);
            district1.AddNewOfficer(officer3);

            district2.AddNewOfficer(officer4);
            district2.AddNewOfficer(officer5);
            district2.AddNewOfficer(officer6);
            district2.AddNewOfficer(officer7);

            List<Lawyer> lawyersList = new List<Lawyer>();
            lawyersList.Add(laywer1);
            lawyersList.Add(lawyer2);
            lawyersList.Add(lawyer3);

            //print all lawyers:
            foreach (var lawyer in lawyersList)
                Console.WriteLine(lawyer);

            Console.WriteLine("break");

            district2.PrintAllOfficers();
            Console.WriteLine("Officer 4 removed: ");
            district2.RemoveOfficer(officer4);
            district2.PrintAllOfficers();



        }
    }
}