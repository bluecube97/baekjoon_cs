internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int t = int.Parse(isr.ReadLine());
        int funny = 0;

        int[] init = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int prevL = init[0];
        int prevR = init[1];

        if (prevL == prevR && prevL != 0)
        {
            funny++;
        }

        for (int i = 1; i < t; i++)
        {
            int[] lr = isr.ReadLine().Split().Select(int.Parse).ToArray();
            int l = lr[0];
            int r = lr[1];

            if (prevL == l && l != 0)
            {
                funny++;
            }

            if (prevR == r && r != 0)
            {
                funny++;
            }

            if (l == r && l != 0)
            {
                funny++;
            }

            prevL = l;
            prevR = r;
        }

        Console.WriteLine(funny);
    }
}