internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] abn = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int a = abn[0];
        int b = abn[1];
        int n = abn[2];

        List<int> height = new List<int>();
        int baseHeight = a * n;

        for (int i = 1; i <= n; i++)
        {
            height.Add(baseHeight + b * i);
        }

        height.Sort();
        Console.WriteLine(string.Join(" ", height));
    }
}