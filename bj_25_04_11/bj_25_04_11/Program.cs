internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        int[] heightArr = new int[n];

        for (int i = 0; i < n; i++)
        {
            heightArr[i] = int.Parse(isr.ReadLine());
        }

        int maxHeight = heightArr[n - 1];
        int count = 0;

        for (int i = n - 2; i >= 0; i--)
        {
            if (heightArr[i] > maxHeight)
            {
                count++;
                maxHeight = heightArr[i];
            }
        }

        count++;
        Console.WriteLine(count);
    }
}