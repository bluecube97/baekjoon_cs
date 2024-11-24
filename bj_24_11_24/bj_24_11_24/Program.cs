internal class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] cow = new int[11];
        bool[] isNewCow = Enumerable.Repeat(true, 11).ToArray();
        int crossCount = 0;

        for (int i = 0; i < N; i++)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int num = input[0];
            int location = input[1];

            if (cow[num] != location && isNewCow[num] == false)
            {
                crossCount++;
            }
            else
            {
                isNewCow[num] = false;
            }
            cow[num] = location;
        }

        Console.WriteLine(crossCount);
    }
}