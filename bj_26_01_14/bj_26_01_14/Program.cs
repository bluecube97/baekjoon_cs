internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());

        List<int> list = new List<int>();

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                list.Add(i);
            }
        }

        int sum = list.Sum();
        Console.WriteLine(sum * 5 - 24);
    }
}