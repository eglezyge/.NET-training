using System;

class Enhanced
{
    static void Main(string[] args)
    {
        double num1;
        double num2;
        for (; ; )
        {
            try
            {
                Console.WriteLine("Enter 1st number:");
                num1 = Convert.ToDouble(Console.ReadLine());
                break;
            }
            catch
            {
                Console.WriteLine("It has to be a number, try again.");
            }
        }
        for (; ; )
        {
            try
            {
                Console.WriteLine("Enter 2nd number:");
                num2 = Convert.ToDouble(Console.ReadLine());
                break;
            }
            catch
            {
                Console.WriteLine("It has to be a number, try again.");
            }
        }
        string? char1;
        bool badChar = true;
        bool zeroDivision = false;
        for (; badChar; )
        {
            Console.WriteLine("Enter one of five characters for wanted operation: * / % + or - :");
            char1 = Console.ReadLine();
            badChar = false;
            if (char1 == "*")
            {
                double resultMult = num1 * num2;
                Console.WriteLine("You chose multiplication. The result is: " + resultMult);
                break;
            }
            else if (char1 == "/")
            {
                if (num2 == 0)
                {
                    zeroDivision = true;
                }
                else
                {
                    double resultDiv = num1 / num2;
                    Console.WriteLine("You chose division. The result is: " + resultDiv);
                    break;
                }
            }
            else if (char1 == "%")
            {
                double resultMod = num1 % num2;
                Console.WriteLine("You chose modulo. The result is: " + resultMod);
                break;
            }
            else if (char1 == "+")
            {
                double resultAdd = num1 + num2;
                Console.WriteLine("You chose addition. The result is: " + resultAdd);
                break;
            }
            else if (char1 == "-")
            {
                double resultSubtract = num1 - num2;
                Console.WriteLine("You chose subtraction. The result is: " + resultSubtract);
                break;
            }
            badChar = true;
            if (zeroDivision == true)
            {
                Console.WriteLine("Division by zero is not possible.");
            }
            else
            {
                Console.WriteLine("It has to be the right character, try again.");
            }
        }
    }
}


  
            //Console.WriteLine("Please enter a number");
            //var num1str = Console.ReadLine();
            //Console.WriteLine("Please enter another number");
            //var num2str = Console.ReadLine();
            //Console.WriteLine("Enter one of five characters for wanted operation: * / % + or - ");
            //var char1 = Console.ReadLine();
            //double num1 = Double.Parse(num1str);
            //double num2 = Double.Parse(num2str);
            //if (char1 == "*")
            //{ 
            //    double resultMult = num1 * num2;
            //    Console.WriteLine("You chose multiplication. The result is:" + resultMult);
            //}
            //else if (char1 == "/")
            //{
            //    double resultDiv = num1 / num2;
            //    Console.WriteLine("You chose division. The result is:" + resultDiv);
            //}
            //else if (char1 == "%")
            //{
            //    double resultMod = num1 % num2;
            //    Console.WriteLine("You chose modulo. The result is:" + resultMod);
            //}
            //else if (char1 == "+")
            //{
            //    double resultAdd = num1 + num2;
            //    Console.WriteLine("You chose addition. The result is:" + resultAdd);
            //}
            //else if (char1 == "-")
            //{
            //    double resultSubtract = num1 - num2;
            //    Console.WriteLine("You chose subtraction. The result is:" + resultSubtract);
            //}
            //else
            //{
            //    Console.WriteLine("Operation is not valid, enter the right character.");
            //}