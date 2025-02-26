using System.Numerics;

internal class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = input[0];
        int m = input[1];

        BigInteger extent = BigInteger.Multiply(n, m);
        Console.WriteLine(BigInteger.Divide(extent, 2));
    }
}