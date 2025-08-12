internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        int result = 1;

        for (int i = 0; i < n; i++)
        {
            result *= 2;
        }

        Console.WriteLine(result);
    }
}