internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] tx = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int t = tx[0];
        int x = tx[1];
        int n = int.Parse(isr.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int k = int.Parse(isr.ReadLine());
            int[] time = isr.ReadLine().Split().Select(int.Parse).ToArray();

            if (!time.Contains(x))
            {
                Console.WriteLine("NO");
                return;
            }
        }

        Console.WriteLine("YES");
    }
}