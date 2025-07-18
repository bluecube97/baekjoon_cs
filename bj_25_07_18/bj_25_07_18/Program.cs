internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        if (n > 100000)
        {
            Console.WriteLine("No");
            return;
        }
        Console.WriteLine(n % 2024 == 0 ? "Yes" : "No");
    }
}