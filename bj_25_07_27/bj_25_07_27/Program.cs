internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        long[] nums = isr.ReadLine().Split().Select(long.Parse).ToArray();

        Console.WriteLine(nums[0] + nums[1] + nums[2]);
    }
}