internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] nm = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int n = nm[0];
        int m = nm[1];

        int stress = 0;
        int stomach = 0;

        int[] A = isr.ReadLine().Split().Select(int.Parse).ToArray();

        for (int i = 0; i < n; i++)
        {
            stress += A[i];
            if (stress < 0)
            {
                stress = 0;
            }

            if (stress >= m)
            {
                stomach++;
            }
        }

        Console.WriteLine(stomach);
    }
}