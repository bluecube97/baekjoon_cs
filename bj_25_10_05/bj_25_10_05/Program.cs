internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] nmk = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int n = nmk[0];
        int m = nmk[1];
        int k = nmk[2];

        int t = k - 3;
        int next = (m - 1 + t) % n;

        if (next < 0)
        {
            next += n;
        }

        Console.WriteLine(next + 1);
    }
}