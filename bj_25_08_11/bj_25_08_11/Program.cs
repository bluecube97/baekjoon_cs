internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int totalValue = int.Parse(isr.ReadLine());
        int possibleValue = 0;
        for (int i = 0; i < 9; i++)
        {
            possibleValue += int.Parse(isr.ReadLine());
        }

        Console.WriteLine(totalValue - possibleValue);
    }
}