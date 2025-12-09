internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());

        if (n == 0)
        {
            Console.WriteLine(0);
            return;
        }

        int[] scoreArr = new int[n];
        int cut = (int)Math.Round(n * 0.15, MidpointRounding.AwayFromZero);

        for (int i = 0; i < n; i++)
        {
            scoreArr[i] = int.Parse(isr.ReadLine());
        }

        Array.Sort(scoreArr);
        int sum = 0;

        for (int i = cut; i < n - cut; i++)
        {
            sum += scoreArr[i];
        }

        double average = (double)sum / (n - cut * 2);
        Console.WriteLine((int)Math.Round(average, MidpointRounding.AwayFromZero));
    }
}