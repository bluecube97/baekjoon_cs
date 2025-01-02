internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        Console.WriteLine(sum);

        sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        Console.WriteLine(sum * sum);

        sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i * i * i;
        }
        Console.WriteLine(sum);
    }
}