using System.Numerics;

internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        BigInteger n = BigInteger.Parse(isr.ReadLine());

        if (n >= -32768 && n <= 32767)
        {
            Console.WriteLine("short");
        }
        else if (n >= -2147483648 && n <= 2147483647)
        {
            Console.WriteLine("int");
        }
        else if (n >= -9223372036854775808 && n <= 9223372036854775807)
        {
            Console.WriteLine("long long");
        }
    }
}