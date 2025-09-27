internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        int[] pqrs = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int p = pqrs[0];
        int q = pqrs[1];
        int r = pqrs[2];
        int s = pqrs[3];

        int a = int.Parse(isr.ReadLine());

        long[] S = new long[n + 1];
        S[1] = a;

        for (int i = 1; i <= n; i++)
        {
            if (2 * i <= n)
                S[2 * i] = p * S[i] + q;
            if (2 * i + 1 <= n)
                S[2 * i + 1] = r * S[i] + s;
        }

        long sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += S[i];
        }

        Console.WriteLine(sum);
    }
}