internal class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = input[0];
        int x = input[1];
        int mod = 1000000007;

        int[] aArr = new int[n + 1];
        int[] iArr = new int[n + 1];

        for (int i = 0; i <= n; i++)
        {
            input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            aArr[i] = input[0];
            iArr[i] = input[1];
        }

        long result = aArr[0];

        for (int i = 0; i < n; i++)
        {
            result = (result * x + aArr[i + 1]) % mod;
        }

        Console.WriteLine(result);
    }
}