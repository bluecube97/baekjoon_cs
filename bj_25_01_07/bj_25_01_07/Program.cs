internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        int ppapCount = 0;

        for (int i = 0; i < n - 3; i++)
        {
            if (input[i] == 'p' && input[i + 1] == 'P' && input[i + 2] == 'A' && input[i + 3] == 'p')
            {
                ppapCount++;
                i += 3;
            }
        }

        Console.WriteLine(ppapCount);
    }
}