internal class Program
{
    static void Main(string[] args)
    {
        int testCase = int.Parse(Console.ReadLine());

        for (int i = 0; i < testCase; i++)
        {
            Console.WriteLine("Scenario #" + (i + 1) + ":");
            int m = int.Parse(Console.ReadLine());
            List<string> pwList = new List<string>();

            for (int j = 0; j < m; j++)
            {
                pwList.Add(Console.ReadLine());
            }

            int n = int.Parse(Console.ReadLine());

            for (int j = 0; j < n; j++)
            {
                int[] pwHint = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int k = pwHint[0];

                for (int l = 1; l <= k; l++)
                {
                    Console.Write(pwList[pwHint[l]]);
                }

                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}