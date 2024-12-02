internal class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = input[0];
        int m = input[1];

        string pwHint = Console.ReadLine();

        for (int i = 0; i < m; i++)
        {
            string pw = Console.ReadLine();
            int index = 0;

            foreach (var c in pw)
            {
                if (index != pwHint.Length && c == pwHint[index])
                {
                    index++;
                }
            }

            if (index == pwHint.Length)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}