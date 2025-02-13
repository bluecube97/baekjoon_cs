internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] chicken = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int a = chicken[0];
        int b = chicken[1];
        int c = chicken[2];

        if (a > n)
        {
            a = n;
        }

        if (b > n)
        {
            b = n;
        }

        if (c > n)
        {
            c = n;
        }

        Console.WriteLine(a + b + c);
    }
}