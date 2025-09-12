internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] ckp = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int c = ckp[0];
        int k = ckp[1];
        int p = ckp[2];

        long sum = (long)k * c * (c + 1) / 2 + (long)p * c * (c + 1) * (2 * c + 1) / 6;

        Console.WriteLine(sum);
    }
}