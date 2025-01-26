internal class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = input[0];
        int m = input[1];

        int[,] matA = new int[n, m];
        int[,] matB = new int[n, m];
        int[,] matResult = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            int[] row = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                matA[i, j] = row[j];
            }
        }

        for (int i = 0; i < n; i++)
        {
            int[] row = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                matB[i, j] = row[j];
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matResult[i, j] = matA[i, j] + matB[i, j];
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(matResult[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}