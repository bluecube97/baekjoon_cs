internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        Console.WriteLine(factorial(n));
    }

    private static long factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        else
            return n * factorial(n - 1);
    }
}