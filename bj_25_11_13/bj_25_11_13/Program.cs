internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());
        int[] input = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int a = input[0];
        int b = input[1];
        int c = input[2];

        Console.WriteLine((a + b) % c);
        Console.WriteLine((a % c + b % c) % c);
        Console.WriteLine(a * b % c);
        Console.WriteLine(a % c * (b % c) % c);
    }
}