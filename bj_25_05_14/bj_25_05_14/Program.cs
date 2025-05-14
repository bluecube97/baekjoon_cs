internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] nmk = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int n = nmk[0];
        int m = nmk[1];
        int k = nmk[2];

        Console.WriteLine(Math.Min(m, k) + Math.Min(n - m, n - k));
    }
}