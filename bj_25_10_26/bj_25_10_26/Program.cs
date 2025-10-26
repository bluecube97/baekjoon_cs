internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] m = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int n = int.Parse(isr.ReadLine());

        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            double[] bls = isr.ReadLine().Split().Select(double.Parse).ToArray();
            int b = (int)bls[0];
            double l = bls[1];
            int s = (int)bls[2];

            if (l >= 2 && s >= 17)
            {
                sum += m[b];
            }
        }

        Console.WriteLine(sum);
    }
}