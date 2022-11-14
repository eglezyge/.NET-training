class Practical1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number");
        string number1str = Console.ReadLine();
        Console.WriteLine("Enter another number");
        string number2str = Console.ReadLine();
        int number1 = Int32.Parse(number1str);
        int number2 = Int32.Parse(number2str);
        int result = number1 + number2;
        Console.WriteLine("Addition:" + result);
        int result1 = number1 - number2;
        Console.WriteLine("Subtraction:" + result1);
        int result2 = number1 * number2;
        Console.WriteLine("Multiplication:" + result2);
        double numb1 = Double.Parse(number1str);
        double numb2 = Double.Parse(number2str);
        double result3 = numb1 / numb2;
        Console.WriteLine("Division:" + result3);
    }
}

