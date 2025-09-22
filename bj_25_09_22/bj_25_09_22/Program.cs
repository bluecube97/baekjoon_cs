internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] nx = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int n = nx[0];
        int x = nx[1];

        int[] socks = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int minValue = int.MaxValue;

        for (int i = 0; i < n - 1; i++)
        {
            int sum = socks[i] + socks[i + 1];
            minValue = Math.Min(sum, minValue);
        }

        Console.WriteLine(minValue * x);
    }
}