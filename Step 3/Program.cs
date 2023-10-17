class Program
{
    static void Main()
    {
        List<string> result = new List<string>();
        List<string> inputArray = new List<string> 
        {
            "4856",
            "banana",
            "21",
            "7",
            "elephant",
            "fox"
        };

        foreach (string item in inputArray)
        {
            if (item.Length <= 3)
            {
                result.Add(item);
            }
        }

        foreach (string item in result)
        {
            Console.WriteLine(item);
        }
    }
}