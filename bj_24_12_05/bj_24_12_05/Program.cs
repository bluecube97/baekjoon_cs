internal class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());

        int x = p * a;
        int y = p <= c ? b : b + (p - c) * d;

        Console.WriteLine(Math.Min(x, y));
    }
}