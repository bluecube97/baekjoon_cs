internal class Program
{
    static void Main(string[] args)
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        int[] xs = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int x = xs[0];
        int s = xs[1];

        for (int i = 0; i < n; i++)
        {
            int[] cp = isr.ReadLine().Split().Select(int.Parse).ToArray();
            int c = cp[0];
            int p = cp[1];

            if (c <= x && p > s)
            {
                Console.WriteLine("YES");
                return;
            }
        }

        Console.WriteLine("NO");
    }
}