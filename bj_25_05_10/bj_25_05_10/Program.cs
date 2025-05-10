internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] ab = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int a = ab[0];
        int b = ab[1];

        long sum = 1;

        for (int i = 1; i <= b; i++)
        {
            sum += (a - 2) * i + 1;
        }

        Console.WriteLine(sum);
    }
}