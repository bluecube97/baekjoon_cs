internal class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        PriorityQueue<int, int> character = new PriorityQueue<int, int>();

        for (int i = 0; i < N; i++)
        {
            int input = int.Parse(Console.ReadLine());
            character.Enqueue(input, -input);
        }

        int unionCount = Math.Min(N, 42);
        int levelSum = 0;
        int statSum = 0;

        for (int i = 0; i < unionCount; i++)
        {
            int level = character.Dequeue();
            levelSum += level;

            if (level < 60)
            {
                continue;
            }
            else if (level < 100)
            {
                statSum += 1;
            }
            else if (level < 140)
            {
                statSum += 2;
            }
            else if (level < 200)
            {
                statSum += 3;
            }
            else if (level < 250)
            {
                statSum += 4;
            }
            else
            {
                statSum += 5;
            }
        }

        Console.Write($"{levelSum} {statSum}");
    }
}