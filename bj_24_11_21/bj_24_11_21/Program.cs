internal class Program
{
    static void Main(string[] args)
    {
        int[] intInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int x = intInput[0];
        int y = intInput[1];

        int a = 100 - x;
        int b = 100 - y;
        int c = 100 - (a + b);
        int d = a * b;
        int q = d / 100;
        int r = d % 100;

        Console.WriteLine($"{a} {b} {c} {d} {q} {r}");
        Console.WriteLine($"{c + q} {r}");
    }
}