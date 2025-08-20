internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] xn = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int x = xn[0];
        int n = xn[1];

        for (int i = 0; i < n; i++)
        {
            if (x % 2 == 0)
            {
                x /= 2;
                x ^= 6;
            }
            else
            {
                x *= 2;
                x ^= 6;
            }
        }

        Console.WriteLine(x);
    }
}