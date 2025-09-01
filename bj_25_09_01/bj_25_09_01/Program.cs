using System.Numerics;
using System.Text;

internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int k = int.Parse(isr.ReadLine());

        if (k == 1)
        {
            Console.WriteLine("1");
            return;
        }

        StringBuilder sb = new StringBuilder();
        sb.Append('1', k);
        sb.Append('0', k - 1);

        Console.WriteLine(sb.ToString());
    }
}