internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] nm = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int n = nm[0];
        int m = nm[1];

        if (m == 1 || m == 2)
        {
            Console.WriteLine("NEWBIE!");
        }
        else if (m <= n)
        {
            Console.WriteLine("OLDBIE!");
        }
        else
        {
            Console.WriteLine("TLE!");
        }
    }
}