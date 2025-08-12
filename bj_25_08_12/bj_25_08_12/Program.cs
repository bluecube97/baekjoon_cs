internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int sum = 0;

        for (int i = 0; i < 5; i++)
        {
            int score = int.Parse(isr.ReadLine());
            if (score < 40)
            {
                score = 40;
            }
            sum += score;
        }

        Console.WriteLine(sum / 5);
    }
}