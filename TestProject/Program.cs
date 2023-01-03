namespace TestProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int arraySize;
            ////bool arrNotProvided = true;
            //Console.WriteLine("Enter array size.");
            //while (true)
            //{
            //     try
            //    {
            //        arraySize = Int32.Parse(Console.ReadLine());
            //        break;
            //        //arrNotProvided = false;
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Number is not valid. Please enter an integer.");
            //    }
            //}
            //Console.WriteLine("Thank you.");

            //string[] userArray = new string[arraySize];

            //for (int i = 0; i < arraySize; i++)
            //{
            //    Console.WriteLine("Enter the element " + i);
            //    var element = Console.ReadLine();
            //    userArray[i] = element;
            //}
            //Console.WriteLine("Your elements are: ");

            //foreach (var element in userArray)
            //{
            //    Console.WriteLine(element);
            //}
            Console.WriteLine("Enter integer array in one line separated by space.");
            string userArray = Console.ReadLine();
            string[] arraySplit = userArray.Split(" ");
            int[] arr = Array.ConvertAll(arraySplit, int.Parse);
            Console.WriteLine("Your integer array is: ");
            foreach (int i in arr)
                Console.WriteLine(i);

            
        }
    }
}