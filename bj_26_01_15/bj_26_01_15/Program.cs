using System.Numerics;

internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] ab = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int a = ab[0];
        int b = ab[1];

        BigInteger result = 1;

        for (int i = a; i <= b; i++)
        {
            result = BigInteger.Multiply(result, i * (i + 1) / 2);
        }

        Console.WriteLine(BigInteger.Remainder(result, 14579));
    }
}