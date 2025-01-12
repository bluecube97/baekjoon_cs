internal class Program
{
    static void Main(string[] args)
    {
        double n = int.Parse(Console.ReadLine());
        double x = int.Parse(Console.ReadLine());

        double discountPrice = n * (1 - x / 100);
        double result = (n - discountPrice) / discountPrice * 100;

        Console.WriteLine($"{result:F6}");
    }
}