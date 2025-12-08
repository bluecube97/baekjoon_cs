internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        long[] nq = isr.ReadLine().Split().Select(long.Parse).ToArray();
        long n = nq[0];
        long q = nq[1];
        long minPrice = long.MaxValue;
        int index = 1;

        for (int i = 0; i < n; i++)
        {
            long[] pkc = isr.ReadLine().Split().Select(long.Parse).ToArray();
            long p = pkc[0];
            long k = pkc[1];
            long c = pkc[2];

            long T = (q - 1) / k;
            long extra = c * (T * (T + 1) / 2);
            long price = p + extra;

            if (price < minPrice)
            {
                minPrice = price;
                index = i + 1;
            }
        }

        Console.WriteLine("{0} {1}", index, minPrice);
    }
}