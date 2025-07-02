using System.Numerics;
using System.Text;

internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        string binary = isr.ReadLine();

        BigInteger decimalNum = BigInteger.Zero;
        foreach (var c in binary)
        {
            decimalNum <<= 1;
            if (c == '1')
            {
                decimalNum += 1;
            }
        }

        BigInteger result = decimalNum * 17;

        if (result.IsZero)
        {
            Console.WriteLine("0");
            return;
        }

        var sb = new StringBuilder();
        while (result > 0)
        {
            sb.Insert(0, (result % 2).ToString());
            result /= 2;
        }

        Console.WriteLine(sb.ToString());
    }
}