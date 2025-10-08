internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] ab = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int a = ab[0];
        int b = ab[1];

        int[] kx = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int k = kx[0];
        int x = kx[1];

        int start = Math.Max(a, k - x);
        int end = Math.Min(b, k + x);

        int count = end - start + 1;

        if (count <= 0)
        {
            Console.WriteLine("IMPOSSIBLE");
        }
        else
        {
            Console.WriteLine(count);
        }
    }
}