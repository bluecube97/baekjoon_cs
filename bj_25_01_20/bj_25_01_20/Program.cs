internal class Program
{
    static void Main(string[] args)
    {
        var inputStreamReader = new StreamReader(Console.OpenStandardInput());
        int[] input = inputStreamReader.ReadLine().Split().Select(int.Parse).ToArray();
        int n = input[0];
        int m = input[1];
        int k = input[2];

        int[] floor = new int[n];

        for (int i = 0; i < m; i++)
        {
            input = inputStreamReader.ReadLine().Split().Select(int.Parse).ToArray();
            int t = input[0];
            int r = input[1];

            floor[0] += r;

            if (floor[0] > k)
            {
                Console.WriteLine($"{i + 1} {1}");
                return;
            }
        }

        Console.WriteLine(-1);
    }
}