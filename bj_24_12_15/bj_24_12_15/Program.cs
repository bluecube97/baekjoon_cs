using System.Numerics;

internal class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        BigInteger A = BigInteger.Parse(input[0]);
        BigInteger B = BigInteger.Parse(input[1]);

        int precision = 1000;
        string result = DivideWithPrecision(A, B, precision);

        Console.WriteLine(result);
    }

    static string DivideWithPrecision(BigInteger A, BigInteger B, int precision)
    {
        BigInteger integerPart = A / B;

        BigInteger remainder = A % B;
        string decimalPart = "";

        for (int i = 0; i < precision; i++)
        {
            remainder *= 10;
            decimalPart += (remainder / B).ToString();
            remainder %= B;

            if (remainder == 0)
                break;
        }

        decimalPart = decimalPart.TrimEnd('0');
        return integerPart + (decimalPart.Length > 0 ? "." + decimalPart : "");
    }
}