internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] nk = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int n = nk[0];
        int k = nk[1];

        int suika = (int)Math.Pow(2, n - 1);
        Console.WriteLine(k / suika);
    }
}