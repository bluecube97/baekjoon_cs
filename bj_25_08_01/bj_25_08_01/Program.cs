internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] nl = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int n = nl[0], l = nl[1];

        int best = 0;
        int bestCount = 0;

        for (int i = 0; i < n; i++)
        {
            string zebra = isr.ReadLine();
            bool isBlack;
            int lineCount = 0;

            if (zebra[0] == '0')
            {
                isBlack = false;
            }
            else
            {
                isBlack = true;
                lineCount++;
            }

            foreach (var line in zebra)
            {
                if (isBlack && line == '0')
                {
                    isBlack = false;
                }
                else if (!isBlack && line == '1')
                {
                    isBlack = true;
                    lineCount++;
                }
            }

            if (best < lineCount)
            {
                best = lineCount;
                bestCount = 1;
            }
            else if (best == lineCount)
            {
                bestCount++;
            }
        }

        Console.WriteLine("{0} {1}", best, bestCount);
    }
}