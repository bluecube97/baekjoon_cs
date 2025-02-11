internal class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);

        int[,] map = new int[n, m];
        bool[,] visited = new bool[n, m];
        Queue<(int posX, int posY, int time)> queue = new Queue<(int, int, int)>();

        queue.Enqueue((0, 0, 0));
        visited[0, 0] = true;

        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            for (int j = 0; j < m; j++)
            {
                map[i, j] = int.Parse(line[j].ToString());
            }
        }

        while (queue.Count > 0)
        {
            var (currentX, currentY, time) = queue.Dequeue();

            foreach (var next in new (int, int)[] {(currentX - 1, currentY), (currentX + 1, currentY), (currentX, currentY - 1), (currentX, currentY + 1)})
            {
                if (next == (n - 1, m) || next == (n + 1, m) || next == (n, m - 1) || next == (n, m + 1))
                {
                    Console.WriteLine(time + 1);
                    return;
                }

                if (next.Item1 >= 0 && next.Item1 < n && next.Item2 >= 0 && next.Item2 < m && map[next.Item1, next.Item2] == 1 && !visited[next.Item1, next.Item2])
                {
                    visited[next.Item1, next.Item2] = true;
                    queue.Enqueue((next.Item1, next.Item2, time + 1));
                }
            }
        }
    }
}