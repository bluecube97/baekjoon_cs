internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] player = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int a = player[0], b = player[1], c = player[2], d = player[3];

        int minDiff = int.MaxValue;

        minDiff = Math.Min(Math.Abs((a + b) - (c + d)), minDiff);
        minDiff = Math.Min(Math.Abs((a + c) - (b + d)), minDiff);
        minDiff = Math.Min(Math.Abs((a + d) - (b + c)), minDiff);

        Console.WriteLine(minDiff);
    }
}