internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] nmk = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int n = nmk[0];
        int m = nmk[1];
        int k = nmk[2];

        int[] classes = new int[k];

        for (int i = 0; i < k; i++)
        {
            int[] fd = isr.ReadLine().Split().Select(int.Parse).ToArray();
            int f = fd[0];
            int d = fd[1];

            classes[i] = m - d + f;
        }

        int minTime = int.MaxValue;
        int minIndex = -1;

        for (int i = 0; i < k; i++)
        {
            if (minTime > classes[i])
            {
                minTime = classes[i];
                minIndex = i;
            }
        }

        Console.WriteLine(minIndex + 1);
    }
}