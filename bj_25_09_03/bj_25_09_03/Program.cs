internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] input = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int n = input[0];
        int a = input[1];
        int b = input[2];

        if (a == b)
        {
            Console.WriteLine("Anything");
            return;
        }
        Console.WriteLine(a < b ? "Bus" : "Subway");
    }
}