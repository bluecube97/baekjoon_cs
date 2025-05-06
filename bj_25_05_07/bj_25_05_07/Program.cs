internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] nx = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int n = nx[0];
        int x = nx[1];

        int max = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            int[] st = isr.ReadLine().Split().Select(int.Parse).ToArray();
            int s = st[0];
            int t = st[1];

            if (s + t <= x)
            {
                max = Math.Max(max, s);
            }
        }

        if (max == int.MinValue)
        {
            Console.WriteLine(-1);
        }
        else
        {
            Console.WriteLine(max);
        }
    }
}