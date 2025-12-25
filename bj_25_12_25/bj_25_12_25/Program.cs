internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int t = int.Parse(isr.ReadLine());
        int answer = (int)Math.Round((t * 1.0 / 2) * (t * 1.0 / 2), MidpointRounding.AwayFromZero);

        Console.WriteLine(answer);
    }
}