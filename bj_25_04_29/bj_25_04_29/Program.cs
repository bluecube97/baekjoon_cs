internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] nm = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int n = nm[0];
        int m = nm[1];

        int[] basket = new int[n + 1];

        for (int a = 0; a < m; a++)
        {
            int[] ijk = isr.ReadLine().Split().Select(int.Parse).ToArray();
            int i = ijk[0];
            int j = ijk[1];
            int k = ijk[2];

            for (int b = i; b <= j; b++)
            {
                basket[b] = k;
            }
        }

        for (int i = 1; i <= n; i++)
        {
            Console.Write(basket[i] + " ");
        }
    }
}