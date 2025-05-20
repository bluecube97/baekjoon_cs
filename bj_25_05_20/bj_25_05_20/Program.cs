internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] num = isr.ReadLine().Split().Select(int.Parse).ToArray();
        Array.Sort(num);

        if (num[2] - num[1] == num[1] - num[0])
        {
            Console.WriteLine(num[2] + (num[2] - num[1]));
        }
        else
        {
            int diff = Math.Min(num[2] - num[1], num[1] - num[0]);

            if (num[2] - num[1] == diff)
            {
                Console.WriteLine(num[0] + diff);
            }
            else
            {
                Console.WriteLine(num[2] - diff);
            }
        }
    }
}