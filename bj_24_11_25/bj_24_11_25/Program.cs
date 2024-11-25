internal class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int N = input[0];
        int L = input[1];
        int D = input[2];

        int totalTime = N * L + (N - 1) * 5;

        for (int t = 0; ; t += D)
        {
            bool isQuiet = true;

            for (int i = 0; i < N; i++)
            {
                int songStart = i * (L + 5);
                int songEnd = songStart + L;

                if (t >= songStart && t < songEnd)
                {
                    isQuiet = false;
                    break;
                }
            }

            if (isQuiet)
            {
                Console.WriteLine(t);
                return;
            }

            if (t > totalTime)
            {
                Console.WriteLine(t);
                return;
            }
        }
    }
}