using System.Text;

internal class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = input[0];
        int m = input[1];

        StringBuilder sb = new StringBuilder();

        for (int i = 1; i <= n * m; i++)
        {
            sb.Append(i);
            if (i % m == 0)
            {
                sb.Append('\n');
            }
            else
            {
                sb.Append(' ');
            }
        }

        Console.Write(sb);
    }
}