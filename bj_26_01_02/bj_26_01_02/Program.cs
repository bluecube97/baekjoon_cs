internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] count = new int[100];
        int sum = 0;

        for (int i = 0; i < 10; i++)
        {
            int num = int.Parse(isr.ReadLine());
            count[num / 10]++;
            sum += num;
        }

        (int, int) mode = (0, 0);
        for (int i = 0; i < count.Length; i++)
        {
            if (count[i] > mode.Item2)
            {
                mode = (i, count[i]);
            }
        }

        Console.WriteLine($"{sum / 10}\n{mode.Item1 * 10}");
    }
}