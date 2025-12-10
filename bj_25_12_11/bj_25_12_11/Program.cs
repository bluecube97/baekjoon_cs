internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] inputs = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int n = inputs[0];
        int m = inputs[1];
        int a = inputs[2];
        int b = inputs[3];

        int cost = (n * 3 - m) * a + b;
        Console.WriteLine(n * 3 - m <= 0 ? 0 : cost);
    }
}