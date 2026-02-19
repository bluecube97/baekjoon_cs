internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        long[] input = isr.ReadLine().Split().Select(long.Parse).ToArray();
        long x1 = input[0];
        long y1 = input[1];
        long r1 = input[2];

        input = isr.ReadLine().Split().Select(long.Parse).ToArray();
        long x2 = input[0];
        long y2 = input[1];
        long r2 = input[2];

        long distance = (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1);

        Console.WriteLine(distance >= (r2 + r1) * (r2 + r1) ? "NO" : "YES");
    }
}