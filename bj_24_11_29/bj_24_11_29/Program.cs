internal class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = input[0];
        int k = input[1];
        int T = input[2];

        int[] d = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int discomfortSum = 0;

        for (int i = 0; i < n; i++)
        {
            if (T < k)
            {
                T = T + d[i] + Math.Abs(T - k);
            }
            else if (T > k)
            {
                T = T + d[i] - Math.Abs(T - k);
            }
            else
            {
                T = T + d[i];
            }
            discomfortSum += Math.Abs(T - k);
        }

        Console.WriteLine(discomfortSum);
    }
}