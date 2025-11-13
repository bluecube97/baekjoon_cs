internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] input = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int t1 = input[0];
        int t2 = input[1];

        Console.WriteLine(Math.Min(t1, t2));
    }
}