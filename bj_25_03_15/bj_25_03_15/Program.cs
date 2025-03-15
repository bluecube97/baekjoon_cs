internal class Program
{
    static void Main(string[] args)
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int c = int.Parse(isr.ReadLine());

        for (int i = 0; i < c; i++)
        {
            int[] input = isr.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int sum = 0;

            for (int j = 0; j < n; j++)
            {
                int score = input[j + 1];
                sum += score;
            }

            float avg = (float)sum / n;
            int overAvgCount = 0;

            for (int j = 0; j < n; j++)
            {
                int score = input[j + 1];
                if (score > avg)
                {
                    overAvgCount++;
                }
            }

            Console.WriteLine("{0:F3}%", (float)overAvgCount / n * 100);
        }
    }
}