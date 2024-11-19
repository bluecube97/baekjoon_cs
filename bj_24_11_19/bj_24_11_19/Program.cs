internal class Program
{
    static void Main(string[] args)
    {
        int testCase = int.Parse(Console.ReadLine());

        for (int i = 0; i < testCase; i++)
        {
            double cost = double.Parse(Console.ReadLine());
            double discountCost = cost * 8.0 / 10.0;
            Console.WriteLine($"${discountCost:F2}");
        }
    }
}