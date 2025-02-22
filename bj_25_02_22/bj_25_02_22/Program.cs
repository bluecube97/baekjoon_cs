internal class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = input[0];
        int k = input[1];

        int[] temp = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int maxTemp = int.MinValue;

        for (int i = 0; i < n - k; i++)
        {
            int sum = 0;
            for (int j = 0; j < k; j++)
            {
                sum += temp[i + j];
            }

            if (sum > maxTemp)
            {
                maxTemp = sum;
            }
        }

        Console.WriteLine(maxTemp);
    }
}