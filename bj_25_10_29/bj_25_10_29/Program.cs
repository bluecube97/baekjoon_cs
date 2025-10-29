internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int testCase = int.Parse(isr.ReadLine());

        for (int i = 0; i < testCase; i++)
        {
            int t = int.Parse(isr.ReadLine());
            int endTime = t % 25;
            Console.WriteLine(endTime >= 17 ? "OFFLINE" : "ONLINE");
        }
    }
}