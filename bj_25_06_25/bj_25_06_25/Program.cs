internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] input = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int a = input[0];
        int b = input[1];

        Console.WriteLine("{0} {1}", b - a, b);
    }
}