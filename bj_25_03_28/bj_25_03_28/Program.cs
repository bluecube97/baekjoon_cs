internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] nk = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int[] multiTab = isr.ReadLine().Split().Select(int.Parse).ToArray();

        int n = nk[0];
        int k = nk[1];

        int count = 0;

        for (int i = 0; i < k; i++)
        {
            int hole = multiTab[i];

            if (hole % 2 == 0)
            {
                count += hole / 2;
            }
            else
            {
                count += hole / 2 + 1;
            }
        }

        if (count >= n)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}