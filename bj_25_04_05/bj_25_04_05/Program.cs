internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int aScore = 0;
        int bScore = 0;

        int n = int.Parse(isr.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int[] ab = isr.ReadLine().Split().Select(int.Parse).ToArray();
            int a = ab[0];
            int b = ab[1];

            if (a > b)
            {
                aScore++;
            }
            else if (a < b)
            {
                bScore++;
            }
        }

        Console.WriteLine($"{aScore} {bScore}");
    }
}