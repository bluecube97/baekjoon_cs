internal class Program
{
    static void Main(string[] args)
    {
        string title = Console.ReadLine();

        if (title.Contains("social") || title.Contains("history") || title.Contains("language") || title.Contains("literacy"))
        {
            Console.WriteLine("digital humanities");
        }
        else if (title.Contains("bigdata") || title.Contains("public") || title.Contains("society"))
        {
            Console.WriteLine("public bigdata");
        }
    }
}