internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        int[] T = isr.ReadLine().Split().Select(int.Parse).ToArray();

        int total = T.Sum() + 8 * (n - 1);

        Console.WriteLine($"{total / 24} {total % 24}");
    }
}