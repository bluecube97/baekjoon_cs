internal class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int n = input[0];
        int t = input[1];

        int[] task = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for (int i = 0; i < n; i++)
        {
            t -= task[i];
            if (t < 0)
            {
                Console.WriteLine(i);
                return;
            }
        }

        Console.WriteLine(n);
    }
}