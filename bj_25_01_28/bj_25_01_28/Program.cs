internal class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = input[0];
        int m = input[1];
        int k = input[2];

        for (int i = 0; i < k; i++)
        {
            if (n > 2 * m)
            {
                n--;
            }
            else
            {
                m--;
            }
        }

        Console.WriteLine(Math.Min(n / 2, m));
    }
}