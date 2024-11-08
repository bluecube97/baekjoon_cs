internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        long sum = 0;

        for (int i = 0; i < n; i++)
        {
            long[] arr = Console.ReadLine().Split().Select(long.Parse).ToArray();
            foreach (var num in arr)
            {
                sum += num;
            }
        }

        Console.WriteLine(sum);
    }
}