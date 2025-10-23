internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        int[] s = isr.ReadLine().Split().Select(int.Parse).ToArray();

        int strig = 0;
        int maxStrig = 0;

        for (int i = 0; i < n; i++)
        {
            if (s[i] > 0)
            {
                strig++;
                maxStrig = Math.Max(maxStrig, strig);
            }
            else
            {
                strig = 0;
            }
        }

        Console.WriteLine(maxStrig);
    }
}