internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string answer = Console.ReadLine();

        string Adrian = "ABC";
        string Bruno = "BABC";
        string Goran = "CCAABB";

        int AdrianScore = 0;
        int BrunoScore = 0;
        int GoranScore = 0;

        for (int i = 0; i < n; i++)
        {
            if (answer[i] == Adrian[i % 3])
            {
                AdrianScore++;
            }

            if (answer[i] == Bruno[i % 4])
            {
                BrunoScore++;
            }

            if (answer[i] == Goran[i % 6])
            {
                GoranScore++;
            }
        }

        int maxScore = Math.Max(AdrianScore, Math.Max(BrunoScore, GoranScore));
        Console.WriteLine(maxScore);
        if (AdrianScore == maxScore)
        {
            Console.WriteLine("Adrian");
        }

        if (BrunoScore == maxScore)
        {
            Console.WriteLine("Bruno");
        }

        if (GoranScore == maxScore)
        {
            Console.WriteLine("Goran");
        }
    }
}