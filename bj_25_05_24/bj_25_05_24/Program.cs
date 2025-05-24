internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        int k = int.Parse(isr.ReadLine());

        for (int i = 0; i < k; i++)
        {
            int[] ab = isr.ReadLine().Split().Select(int.Parse).ToArray();
            int a = ab[0];
            int b = ab[1];

            int level = Math.Min(Math.Min(a - 1, b - 1), Math.Min(n - a, n - b));
            int color = level % 3 + 1;

            Console.WriteLine(color);
        }
    }
}