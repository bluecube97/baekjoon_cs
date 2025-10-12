internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        int w = int.Parse(isr.ReadLine());

        int score = n * 10;

        if (n >= 3)
        {
            score += 20;
        }

        if (n == 5)
        {
            score += 50;
        }

        if (w > 1000)
        {
            score -= 15;
        }

        if (score < 0)
        {
            score = 0;
        }

        Console.WriteLine(score);
    }
}