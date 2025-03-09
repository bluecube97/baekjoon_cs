internal class Program
{
    static void Main(string[] args)
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] nm = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int n = nm[0];
        int m = nm[1];

        (int, int) start = new ValueTuple<int, int>();
        (int, int) end = new ValueTuple<int, int>();
        bool isStart = true;

        for (int i = 0; i < n; i++)
        {
            int[] line = isr.ReadLine().Split().Select(int.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                if (line[j] == 1 && isStart)
                {
                    start.Item1 = i;
                    start.Item2 = j;
                    isStart = false;
                }

                if (line[j] == 1 && !isStart)
                {
                    end.Item1 = i;
                    end.Item2 = j;
                }
            }
        }

        Console.WriteLine(Math.Abs(start.Item1 - end.Item1) + Math.Abs(start.Item2 - end.Item2));
    }
}