internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] nm = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int n = nm[0];
        int m = nm[1];

        int count = 0;
        int current = n;

        while (current > 0)
        {
            count += current;
            current /= m;
        }

        Console.WriteLine(count);
    }
}