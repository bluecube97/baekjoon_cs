internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        long[] nm = isr.ReadLine().Split().Select(long.Parse).ToArray();
        long n = nm[0];
        long m = nm[1];

        Console.WriteLine(n == m ? 1 : 0);
    }
}