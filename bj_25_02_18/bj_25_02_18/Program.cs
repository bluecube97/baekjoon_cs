internal class Program
{
    static void Main(string[] args)
    {
        long s = long.Parse(Console.ReadLine());
        int n = 1;

        while (s >= n)
        {
            s -= n;
            n++;
        }

        Console.WriteLine(n - 1);
    }
}