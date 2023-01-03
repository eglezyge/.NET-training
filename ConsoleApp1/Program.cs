static void Main(string[] args)
{
    int arraySize;
    try
    {
        Console.WriteLine("Enter array size");
        arraySize = Int32.Parse(Console.ReadLine());
    }
    catch
    {
        arraySize = 0;
        Console.WriteLine("Number is not valid");
    }
}
