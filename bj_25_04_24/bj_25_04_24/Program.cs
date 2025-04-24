using System.Text;

internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());
        StringBuilder sb = new StringBuilder();

        int[] nm = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int n = nm[0];
        int m = nm[1];

        int[] friend = new int[n + 1];

        for (int i = 0; i < m; i++)
        {
            int[] ab = isr.ReadLine().Split().Select(int.Parse).ToArray();
            int a = ab[0];
            int b = ab[1];

            friend[a]++;
            friend[b]++;
        }

        for (int i = 1; i <= n; i++)
        {
            sb.Append(friend[i]);
            sb.Append('\n');
        }

        Console.Write(sb.ToString());
    }
}