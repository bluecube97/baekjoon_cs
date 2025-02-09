internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            if (Console.ReadLine().Equals("anj"))
            {
                Console.WriteLine("뭐야;");
                return;
            }
        }

        Console.WriteLine("뭐야?");
    }
}