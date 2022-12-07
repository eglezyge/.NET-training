using System.Text.RegularExpressions;

class PhoneValidation
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter your phone number:");
        string phone = Console.ReadLine();
        //bool match = Regex.Match(phone, "^\\+?\\d{1,4}?[-.\\s]?\\(?\\d{1,3}?\\)?[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,9}$").Success;
        bool match = Regex.Match(phone, @"\+370[0-9]{8}$").Success || Regex.Match(phone, @"\+370 [0-9]{8}$").Success || Regex.Match(phone, @"\[0-9]{9}$").Success;
        if (match)
        {
            Console.WriteLine("Your phone is correct: " + phone);
        }
        else
        {
            Console.WriteLine("Wrong phone number provided.");
        }
    }
}