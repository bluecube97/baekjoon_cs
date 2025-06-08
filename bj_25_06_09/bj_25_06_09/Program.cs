internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        while (isr.Peek() != -1)
        {
            int[] nk = isr.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nk[0], k = nk[1];
            int chicken = n;

            while (n > 0)
            {
                n -= k;
                n++;
                chicken++;
            }

            Console.WriteLine(--chicken);
        }
    }
}