internal class Program
{
    static void Main(string[] args)
    {
        int testCase = int.Parse(Console.ReadLine());

        for (int i = 0; i < testCase; i++)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int a = input[0];
            int b = input[1];

            int n = a / b;
            int result = 0;

            for (int j = 1; j <= n; j++)
            {
                result += 2 * j - 1;
            }

            Console.WriteLine(result);
        }
    }
}