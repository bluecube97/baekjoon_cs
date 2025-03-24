internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int day = int.Parse(isr.ReadLine());
        int count = 0;
        int[] carNum = isr.ReadLine().Split().Select(int.Parse).ToArray();

        foreach (var num in carNum)
        {
            if (num % 10 == day)
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}