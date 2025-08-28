internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        int result = 0;
        int init = 2;

        for (int i = 1; i <= n; i++)
        {
            init = init * 2 - 1;
            result = init * init;
        }

        Console.WriteLine(result);
    }
}