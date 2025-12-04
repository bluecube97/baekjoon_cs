internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        string[] tower = isr.ReadLine().Split();

        int pushCount = 1;
        int prevHeight = int.Parse(tower[0]);

        for (int i = 1; i < n; i++)
        {
            int cur = int.Parse(tower[i]);

            if (prevHeight <= cur)
                pushCount++;

            prevHeight = cur;
        }

        Console.WriteLine(pushCount);
    }
}