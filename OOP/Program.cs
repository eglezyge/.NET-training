using OOP;

namespace OOP
{
    class OOP
    {
        static void Main(string[] args)
        {
            Person person = new Person("Egle", "Zyge");
            Console.WriteLine("The person created is " + person.FirstName + " " + person.LastName);

            Student student = new Student("Vilnius university", "Zygis", "Zygas");
            Console.WriteLine("The student created is " + student.FirstName + " " + student.LastName + " from " + student.University);
        }
    }
}



