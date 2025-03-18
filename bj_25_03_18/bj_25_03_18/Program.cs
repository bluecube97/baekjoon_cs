using System.Text;

internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());
        var sb = new StringBuilder();

        int[] nmq = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int n = nmq[0];
        int m = nmq[1];
        int q = nmq[2];

        int[,] arr = new int[n, m];

        int[] rowIndex = new int[n];
        for (int i = 0; i < n; i++)
        {
            rowIndex[i] = i;
            int[] row = isr.ReadLine().Split().Select(int.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                arr[i, j] = row[j];
            }
        }

        for (int i = 0; i < q; i++)
        {
            int[] query = isr.ReadLine().Split().Select(int.Parse).ToArray();
            if (query[0] == 0)
            {
                arr[rowIndex[query[1]], query[2]] = query[3];
            }
            else if (query[0] == 1)
            {
                (rowIndex[query[1]], rowIndex[query[2]]) = (rowIndex[query[2]], rowIndex[query[1]]);
            }
        }

        using (var osw = new StreamWriter(Console.OpenStandardOutput()))
        {
            for (int i = 0; i < n; i++)
            {
                int row = rowIndex[i];
                for (int j = 0; j < m; j++)
                {
                    sb.Append(arr[row, j]).Append(' ');
                }
                sb.AppendLine();
            }
            osw.Write(sb.ToString());
        }
    }
}