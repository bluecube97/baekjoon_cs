internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] nc = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int n = nc[0], c = nc[1];

        bool[] isUsed = new bool[c + 1];

        for (int i = 0; i < n; i++)
        {
            int interval = int.Parse(isr.ReadLine());

            for (int j = 1; j <= c; j++)
            {
                if (j % interval == 0)
                {
                    isUsed[j] = true;
                }
            }
        }

        int boomCount = isUsed.Count(x => x);
        Console.WriteLine(boomCount);
    }
}