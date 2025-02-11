internal class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int k = int.Parse(input[1]);

        if (n == k)
        {
            Console.WriteLine(0);
            return;
        }

        const int MAX = 100000;
        bool[] visited = new bool[MAX + 1];
        Queue<(int position, int time)> queue = new Queue<(int, int)>();

        queue.Enqueue((n, 0));
        visited[n] = true;

        while (queue.Count > 0)
        {
            var (current, time) = queue.Dequeue();

            foreach (int next in new int[] { current - 1, current + 1, current * 2 })
            {
                if (next == k)
                {
                    Console.WriteLine(time + 1);
                    return;
                }

                if (next >= 0 && next <= MAX && !visited[next])
                {
                    visited[next] = true;
                    queue.Enqueue((next, time + 1));
                }
            }
        }
    }
}