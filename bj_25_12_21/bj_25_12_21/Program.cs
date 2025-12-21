using System.Numerics;

internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        string[] input = isr.ReadLine().Split().ToArray();
        BigInteger a = BigInteger.Parse(input[0]);
        BigInteger b = BigInteger.Parse(input[1]);

        BigInteger result = a + b;
        Console.WriteLine(result);
    }
}