internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] input = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int AsumB = input[0];
        int AdifB = input[1];

        if ((AsumB + AdifB) % 2 != 0 || AsumB < AdifB)
        {
            Console.WriteLine(-1);
            return;
        }

        int a = (AsumB + AdifB) / 2;
        int b = AsumB - a;

        Console.WriteLine(a > b ? $"{a} {b}" : $"{b} {a}");
    }
}