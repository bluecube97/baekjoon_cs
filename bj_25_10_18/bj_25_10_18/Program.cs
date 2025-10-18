internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());

        int maxT = int.MinValue;
        int minB = int.MaxValue;

        for (int i = 0; i < n; i++)
        {
            int[] tb = isr.ReadLine().Split().Select(int.Parse).ToArray();
            int t = tb[0];
            int b = tb[1];

            maxT = Math.Max(maxT, t);
            minB = Math.Min(minB, b);
        }

        Console.WriteLine((maxT * minB) % 7 + 1);
    }
}