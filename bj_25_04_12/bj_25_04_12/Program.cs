internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        long[] msx = isr.ReadLine().Split().Select(long.Parse).ToArray();
        long m = msx[0];
        long seed = msx[1];
        long x1 = msx[2];
        long x2 = msx[3];

        long delta1 = (x1 - seed + m) % m;
        long delta2 = (x2 - x1 + m) % m;

        long invDelta1 = ModInverse(delta1, m);
        long a = (delta2 * invDelta1) % m;
        long c = (x1 - a * seed % m + m) % m;

        Console.WriteLine($"{a} {c}");
    }

    static long ModInverse(long x, long mod)
    {
        return ModPow(x, mod - 2, mod);
    }

    static long ModPow(long baseValue, long exponent, long mod)
    {
        long result = 1;
        baseValue %= mod;

        while (exponent > 0)
        {
            if ((exponent & 1) == 1)
                result = (result * baseValue) % mod;

            baseValue = (baseValue * baseValue) % mod;
            exponent >>= 1;
        }

        return result;
    }
}