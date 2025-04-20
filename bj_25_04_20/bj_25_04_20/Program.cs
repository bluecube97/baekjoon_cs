internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] nt = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int n = nt[0];
        int t = nt[1];

        int cycle = 4 * n - 2;
        int where = (t - 1) % cycle;

        int result;
        if (where < 2 * n - 1)
        {
            result = where + 1;
        }
        else
        {
            result = 2 * n - (where - (2 * n - 1));
        }

        Console.WriteLine(result);
    }
}