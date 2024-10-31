internal class Program
{
    static void Main(string[] args)
    {
        int day = int.Parse(Console.ReadLine());
        int success = 0;

        string[] plan = Console.ReadLine().Split(' ');
        string[] study = Console.ReadLine().Split(' ');

        for (int i = 0; i < day; i++)
        {
            if (int.Parse(plan[i]) <= int.Parse(study[i]))
            {
                success++;
            }
        }

        Console.WriteLine(success);
    }
}