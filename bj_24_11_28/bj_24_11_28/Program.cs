internal class Program
{
    static void Main(string[] args)
    {
        long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();

        long k = input[0];
        long n = input[1];

        if (n == 1)
        {
            Console.WriteLine(-1);
            return;
        }

        long x = (k * n + (n - 2)) / (n - 1);

        Console.WriteLine(x);
    }
}