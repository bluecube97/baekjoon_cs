internal class Program
{
    static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine());

        for (int i = 0; i < T; i++)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int m = input[1];

            int[] teamWin = new int[n + 1];
            int[] teamLose = new int[n + 1];

            for (int j = 0; j < m; j++)
            {
                int[] input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int a = input2[0];
                int b = input2[1];
                int p = input2[2];
                int q = input2[3];

                teamWin[a] += p;
                teamLose[a] += q;
                teamWin[b] += q;
                teamLose[b] += p;
            }

            PriorityQueue<float, float> expMaxValueQueue = new PriorityQueue<float, float>();
            PriorityQueue<float, float> expMinValueQueue = new PriorityQueue<float, float>();

            float[] winPoint = new float[n + 1];
            float[] losePoint = new float[n + 1];

            for (int j = 1; j <= n; j++)
            {
                winPoint[j] += teamWin[j];
                losePoint[j] += teamLose[j];
            }

            for (int j = 1; j <= n; j++)
            {
                if (winPoint[j] == 0 && losePoint[j] == 0)
                {
                    expMaxValueQueue.Enqueue(0, -0);
                    expMinValueQueue.Enqueue(0, 0);
                }
                else
                {
                    float expValue = winPoint[j] * winPoint[j] /
                                     (winPoint[j] * winPoint[j] + losePoint[j] * losePoint[j]);
                    expMaxValueQueue.Enqueue(expValue, -expValue);
                    expMinValueQueue.Enqueue(expValue, expValue);
                }
            }

            Console.WriteLine(Math.Floor(expMaxValueQueue.Dequeue() * 1000));
            Console.WriteLine(Math.Floor(expMinValueQueue.Dequeue() * 1000));
        }
    }
}