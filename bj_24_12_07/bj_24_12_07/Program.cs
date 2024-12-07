internal class Program
{
    static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine());

        for (int i = 0; i < T; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            string x = input[0];
            string y = input[1];

            int strLen = x.Length;
            int[] distance = new int[strLen];

            for (int j = 0; j < strLen; j++)
            {
                distance[j] = y[j] - x[j];
                if (distance[j] < 0)
                {
                    distance[j] += 26;
                }
            }

            Console.WriteLine("Distances: " + string.Join(" ", distance));
        }
    }
}