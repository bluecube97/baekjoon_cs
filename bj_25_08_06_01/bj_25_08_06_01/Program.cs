internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] nmk = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int n = nmk[0], m = nmk[1], k = nmk[2];

        int minSolve = Math.Max(0, n - m * k);
        int maxSolve = n - m * (k - 1) - 1;

        Console.WriteLine("{0} {1}", minSolve, maxSolve);
    }
}