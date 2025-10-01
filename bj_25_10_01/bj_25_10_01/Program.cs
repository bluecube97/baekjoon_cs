internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        n--;

        int defaultValue = 2024 * 12 + 8;
        int result = defaultValue + n * 7;
        int year = result / 12;
        int month = result % 12;
        if (month == 0)
        {
            year--;
            month = 12;
        }

        Console.WriteLine($"{year} {month}");
    }
}