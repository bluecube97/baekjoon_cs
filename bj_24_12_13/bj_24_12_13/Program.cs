internal class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = input[0];
        int k = input[1];

        input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] human = new int[n];

        for (int i = 0; i < n; i++)
        {
            human[i] = input[i];
        }

        Array.Sort(human);
        Console.WriteLine(human[n - k]);
    }
}