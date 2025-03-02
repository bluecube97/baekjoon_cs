using System.Text;

internal class Program
{
    static void Main(string[] args)
    {
        var inputStreamReader = new StreamReader(Console.OpenStandardInput());
        StringBuilder sb = new StringBuilder();
        int t = int.Parse(inputStreamReader.ReadLine());

        for (int i = 0; i < t; i++)
        {
            long[] input = inputStreamReader.ReadLine().Split().Select(long.Parse).ToArray();
            long a = input[0];
            long b = input[1];
            long c = input[2];

            long x = (a + b) * (a + b) + c * c;
            long y = (b + c) * (b + c) + a * a;
            long z = (c + a) * (c + a) + b * b;

            sb.Append(Math.Min(x, Math.Min(y, z)));
            sb.Append('\n');
        }

        Console.WriteLine(sb.ToString());
    }
}