using System;

class Functions
{
    public static void Main(string[] args)
    {
        int[] array = UserInput.EnterArray(); 
        Calculations.PrintNegatives(array);
        Calculations.PrintOdds(array);




        //int arraySize = 0;
        //while (true)
        //{
        //    try
        //    {
        //        arraySize = Int32.Parse(Console.ReadLine());
        //        break;
        //    }
        //    catch
        //    {
        //        Console.WriteLine("The value is worng. Try again.");
        //    }
        //}
        //int[] userArray = new int[arraySize];

        //for (int i = 0; i < arraySize; i++)
        //{
        //    Console.WriteLine("Enter the element " + i++ + " of the array: ");
        //    int element = Int32.Parse(Console.ReadLine());
        //    userArray[i] = element;
        //}
        //Console.WriteLine("Your elements are: ");
        //for (int i = 0; i < arraySize; i++)
        //{
        //    Console.WriteLine(userArray[i]);
        //}
        //Console.WriteLine("List of uneven numbers: ");
        //for (int i = 0; i < arraySize; i++)
        //{
        //    if (userArray[i] % 2 != 0)
        //   Console.Write(userArray[i] + " ");
           
        //}
    }
}

class UserInput
{
    public static int EnterIntNumber()
    {
        int input = 0;
        while (true)
        {
            try
            {
                input = Int32.Parse(Console.ReadLine());
                break;
            }
            catch
            {
                Console.WriteLine("The value is worng. Try again.");
            }
        }
        return input;
    }
    public static int[] EnterArray()
    {
        Console.WriteLine("Please enter the size of the array: ");
        int arraySize = EnterIntNumber();
        int[] UserArray = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            Console.WriteLine("Enter the element " + i + " of the array: ");
            UserArray[i] = EnterIntNumber();
        }
        return UserArray;
    }
}

class Calculations
{
    //public static void Negatives (int[] arr)
    //{
    //    Console.WriteLine ("List of negative numbers: ");
    //    for (int i = 0; i < arr.Length; i++)
    //    {
    //        if (arr[i] < 0)
    //            Console.WriteLine(arr[i] + " ");
    //    }
    //    Console.WriteLine("/n");
    //}

    public static void PrintNegatives(int[] arr)
    {
        Console.Write("Negative elements:");
        foreach (int element in arr)
        {
            if (element < 0)
                Console.Write(" " + element);
        }
        Console.Write("\n");
    }

    public static void PrintOdds(int[] arr)
    {
        int counter = 0;
        Console.Write("Odd elements: ");
        foreach (int element in arr)
        {
            if (element % 2 != 0)
            {
                Console.Write(" " + element);
                counter++;
            }

        }
        Console.Write("\n");
        Console.WriteLine("Number of odd numbers: " + counter);
    }


}