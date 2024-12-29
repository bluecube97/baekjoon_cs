internal class Program
{
    static void Main(string[] args)
    {
        int[] cost = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] timeLine = new int[101];

        for (int i = 0; i < 3; i++)
        {
            int[] time = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int t = time[0]; t < time[1]; t++)
            {
                timeLine[t]++;
            }
        }

        int totalCost = 0;
        foreach (int truckCount in timeLine)
        {
            if (truckCount == 1)
                totalCost += cost[0];
            else if (truckCount == 2)
                totalCost += cost[1] * 2;
            else if (truckCount == 3)
                totalCost += cost[2] * 3;
        }

        Console.WriteLine(totalCost);
    }
}