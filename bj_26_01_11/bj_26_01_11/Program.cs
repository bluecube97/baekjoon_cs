internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int height = 5;
        string bowls = isr.ReadLine();
        char prev = bowls[0];

        foreach (var bowl in bowls)
        {
            if (bowl != prev)
            {
                height += 5;
                prev = bowl;
            }
            height += 5;
        }

        Console.WriteLine(height);
    }
}