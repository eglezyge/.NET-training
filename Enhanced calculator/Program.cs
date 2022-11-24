    class Enhanced
    {
        static void Main(string[] args)
        {
            // Comment
            Console.WriteLine("Please enter a number");
            var num1str = Console.ReadLine();
            Console.WriteLine("Please enter another number");
            var num2str = Console.ReadLine();
            Console.WriteLine("Enter one of five characters for wanted operation: * / % + or - ");
            var char1 = Console.ReadLine();
            int num1 = Int32.Parse(num1str);
            int num2 = Int32.Parse(num2str);
            if (char1 == "*")
            { 
                double resultMult = num1 * num2;
                Console.WriteLine("You chose multiplication. The result is:" + resultMult);
            }
            else if (char1 == "/")
            {
                double resultDiv = num1 / num2;
                Console.WriteLine("You chose division. The result is:" + resultDiv);
            }
            else if (char1 == "%")
            {
                double resultMod = num1 % num2;
                Console.WriteLine("You chose modulo. The result is:" + resultMod);
            }
            else if (char1 == "+")
            {
                double resultAdd = num1 + num2;
                Console.WriteLine("You chose addition. The result is:" + resultAdd);
            }
            else if (char1 == "-")
            {
                double resultSubtract = num1 - num2;
                Console.WriteLine("You chose subtraction. The result is:" + resultSubtract);
            }
            else
            {
                Console.WriteLine("Operation is not valid, enter the right character.");
            }
        }
    }