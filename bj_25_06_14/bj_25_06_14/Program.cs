internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        int[] voteResult = new int[3];
        int[] voteResult3 = new int[3];
        int[] voteResult2 = new int[3];

        for (int i = 0; i < n; i++)
        {
            int[] vote = isr.ReadLine().Split().Select(int.Parse).ToArray();

            for (int j = 0; j < 3; j++)
            {
                voteResult[j] += vote[j];
                if (vote[j] == 3) voteResult3[j]++;
                else if (vote[j] == 2) voteResult2[j]++;
            }
        }

        int maxVote = voteResult.Max();

        var maxIndices = Enumerable.Range(0, 3).Where(i => voteResult[i] == maxVote).ToList();

        if (maxIndices.Count == 1)
        {
            Console.WriteLine("{0} {1}", maxIndices[0] + 1, maxVote);
        }
        else
        {
            int max3 = maxIndices.Max(i => voteResult3[i]);
            var candidates3 = maxIndices.Where(i => voteResult3[i] == max3).ToList();

            if (candidates3.Count == 1)
            {
                Console.WriteLine("{0} {1}", candidates3[0] + 1, maxVote);
            }
            else
            {
                int max2 = candidates3.Max(i => voteResult2[i]);
                var candidates2 = candidates3.Where(i => voteResult2[i] == max2).ToList();

                if (candidates2.Count == 1)
                {
                    Console.WriteLine("{0} {1}", candidates2[0] + 1, maxVote);
                }
                else
                {
                    Console.WriteLine("0 {0}", maxVote);
                }
            }
        }
    }
}