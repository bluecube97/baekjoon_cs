internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());
        
        Dictionary<int, int> xCount = new Dictionary<int, int>();
        Dictionary<int, int> yCount = new Dictionary<int, int>();

        for (int i = 0; i < 3; i++)
        {
            int[] point = isr.ReadLine().Split().Select(int.Parse).ToArray();
            int x = point[0];
            int y = point[1];

            if (xCount.ContainsKey(x))
                xCount[x]++;
            else
                xCount[x] = 1;

            if (yCount.ContainsKey(y))
                yCount[y]++;
            else
                yCount[y] = 1;
        }

        foreach (var el in xCount)
        {
            if (el.Value % 2 == 1)
            {
                Console.Write(el.Key + " ");
                break;
            }
        }

        foreach (var el in yCount)
        {
            if (el.Value % 2 == 1)
            {
                Console.WriteLine(el.Key);
                break;
            }
        }
    }
}