using System.Numerics;

internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        BigInteger n = BigInteger.Parse(isr.ReadLine());
        Console.WriteLine(n % 20000303);
    }
}