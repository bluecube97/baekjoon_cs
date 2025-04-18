internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] nm = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int n = nm[0];
        int m = nm[1];

        long sum = 0;
        long[] a = isr.ReadLine().Split().Select(long.Parse).ToArray();
        long[] b = isr.ReadLine().Split().Select(long.Parse).ToArray();

        sum += a.Sum();
        sum += b.Sum();

        Console.WriteLine(sum);
    }
}