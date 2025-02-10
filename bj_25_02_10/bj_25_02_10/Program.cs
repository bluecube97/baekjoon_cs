internal class Program
{
    static void Main(string[] args)
    {
        int k = int.Parse(Console.ReadLine());

        for (int i = 0; i < k; i++)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int[] score = new int[n];

            for (int j = 1; j <= n; j++)
            {
                score[j - 1] = input[j];
            }

            int maxScore = score.Max();
            int minScore = score.Min();
            Array.Sort(score);
            int largestGap = 0;

            for (int j = 1; j < n; j++)
            {
                int gap = score[j] - score[j - 1];
                if (gap > largestGap)
                {
                    largestGap = gap;
                }
            }

            Console.WriteLine("Class {0}", i + 1);
            Console.WriteLine("Max {0}, Min {1}, Largest gap {2}", maxScore, minScore, largestGap);
        }
    }
}