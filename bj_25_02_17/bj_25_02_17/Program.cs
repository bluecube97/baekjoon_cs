internal class Program
{
    static void Main(string[] args)
    {
        int max = int.MinValue;
        int people = 0;
        for (int i = 0; i < 10; i++)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int drop = input[0];
            int get = input[1];

            people -= drop;
            people += get;

            if (people > max)
            {
                max = people;
            }
        }

        Console.WriteLine(max);
    }
}