internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        int[] score = isr.ReadLine().Split().Select(int.Parse).ToArray();

        Console.WriteLine(score.Max() - score.Min());
    }
}