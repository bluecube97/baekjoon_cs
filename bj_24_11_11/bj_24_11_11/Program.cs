internal class Program
{
    static void Main(string[] args)
    {
        string B1 = Console.ReadLine();
        string B2 = Console.ReadLine();

        long num1 = Convert.ToInt64(B1, 2);
        long num2 = Convert.ToInt64(B2, 2);

        long product = num1 * num2;

        string result = Convert.ToString(product, 2);

        Console.WriteLine(result);
    }
}