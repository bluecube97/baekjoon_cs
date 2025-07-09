internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());

        string top = new string('@', 3 * n) + new string(' ', n) + new string('@', n);
        string middle = new string('@', n) + new string(' ', n) + new string('@', n) + new string(' ', n) + new string('@', n);
        string bottom = new string('@', n) + new string(' ', n) + new string('@', 3 * n);

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(top);
        }

        for (int i = 0; i < 3 * n; i++)
        {
            Console.WriteLine(middle);
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(bottom);
        }
    }
}