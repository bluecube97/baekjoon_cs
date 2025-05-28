internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] ab = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int a = ab[0];
        int b = ab[1];

        double m = (b - a) / 400.0;
        double winRate = 1 / (1 + Math.Pow(10, m));

        Console.WriteLine(winRate);
    }
}