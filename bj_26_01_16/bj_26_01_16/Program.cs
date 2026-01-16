internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] nm = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int n = nm[0];
        int m = nm[1];
        int[] basket = new int[n];

        for (int i = 0; i < n; i++)
        {
            basket[i] = i + 1;
        }

        for (int a = 0; a < m; a++)
        {
            int[] ij = isr.ReadLine().Split().Select(int.Parse).ToArray();
            int i = ij[0];
            int j = ij[1];

            (basket[i - 1], basket[j - 1]) = (basket[j - 1], basket[i - 1]);
        }

        Console.WriteLine(string.Join(" ", basket));
    }
}