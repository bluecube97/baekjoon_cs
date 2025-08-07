internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] nums = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int a = nums[0], b = nums[1], c = nums[2], x = nums[3], y = nums[4];

        int result = int.MaxValue;

        for (int i = 0; i <= Math.Max(x, y); i++)
        {
            int half = i;
            int needA = Math.Max(0, x - half);
            int needB = Math.Max(0, y - half);

            int cost = needA * a + needB * b + half * 2 * c;
            result = Math.Min(result, cost);
        }

        Console.WriteLine(result);
    }
}