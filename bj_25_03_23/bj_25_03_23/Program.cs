internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] abcd = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int a = abcd[0], b = abcd[1], c = abcd[2], d = abcd[3];

        int[] pmn = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int p = pmn[0], m = pmn[1], n = pmn[2];

        Console.WriteLine(GetAttackCount(p, a, b, c, d));
        Console.WriteLine(GetAttackCount(m, a, b, c, d));
        Console.WriteLine(GetAttackCount(n, a, b, c, d));
    }

    static int GetAttackCount(int time, int a, int b, int c, int d)
    {
        int attackCount = 0;

        if ((time - 1) % (a + b) + 1 <= a) attackCount++;
        if ((time - 1) % (c + d) + 1 <= c) attackCount++;

        return attackCount;
    }
}