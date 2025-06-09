internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        int[] vote = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int[] voteResult = new int[n + 1];

        for (int i = 0; i < n; i++)
        {
            voteResult[vote[i]]++;
        }

        int maxVoteCount = 0;
        int maxVote = 0;

        for (int i = 1; i <= n; i++)
        {
            if (maxVote == voteResult[i])
            {
                maxVoteCount++;
            }
            else if (maxVote < voteResult[i])
            {
                maxVoteCount = 1;
                maxVote = voteResult[i];
            }
        }

        if (maxVoteCount > 1)
        {
            Console.WriteLine("skipped");
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                if (voteResult[i] == maxVote)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}