internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());

        int closest = int.MaxValue;

        for (int i = 0; i < n; i++)
        {
            int[] iron = isr.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = iron.Sum();
            if (sum >= 512)
            {
                closest = Math.Min(closest, sum);
            }
        }

        Console.WriteLine(closest == int.MaxValue ? -1 : closest);
    }
}