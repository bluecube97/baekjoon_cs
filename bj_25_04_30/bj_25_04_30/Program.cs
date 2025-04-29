using System.Numerics;

internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int testcase = int.Parse(isr.ReadLine());

        for (int i = 0; i < testcase; i++)
        {
            Console.WriteLine("Scenario #{0}:", i + 1);
            int[] nm = isr.ReadLine().Split().Select(int.Parse).ToArray();
            BigInteger n = nm[0];
            BigInteger m = nm[1];

            BigInteger sum = (n + m) * (m - n + 1) / 2;
            Console.WriteLine(sum);
            Console.WriteLine();
        }
    }
}