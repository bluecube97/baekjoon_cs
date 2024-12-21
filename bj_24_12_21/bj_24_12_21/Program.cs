internal class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int j = input[0];
        int n = input[1];
        int solvableQuestion = 0;

        for (int i = 0; i < n; i++)
        {
            string question = Console.ReadLine();
            int questionSize = 0;

            foreach (var c in question)
            {
                switch (c)
                {
                    case ' ':
                        questionSize++;
                        break;
                    case >= 'a' and <= 'z':
                        questionSize += 2;
                        break;
                    case >= 'A' and <= 'Z':
                        questionSize += 4;
                        break;
                    case >= '0' and <= '9':
                        questionSize += 2;
                        break;
                }
            }

            if (questionSize <= j)
            {
                solvableQuestion++;
            }
        }

        Console.WriteLine(solvableQuestion);
    }
}