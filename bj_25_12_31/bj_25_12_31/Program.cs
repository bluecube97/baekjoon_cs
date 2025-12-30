internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] ycp = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int y = ycp[0] * 2;
        int c = ycp[1];
        int p = ycp[2] * 2;

        int min = Math.Min(y, Math.Min(c, p));

        Console.WriteLine(min / 2);
    }
}