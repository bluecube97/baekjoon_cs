internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] nm = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int n = nm[0];
        int m = nm[1];

        int[] input = isr.ReadLine().Split().Select(int.Parse).ToArray();
        long result = 1;

        for (int i = 0; i < n; i++)
        {
            result = result * (input[i] % m) % m;
        }

        Console.WriteLine(result);
    }
}