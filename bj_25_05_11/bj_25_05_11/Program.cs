internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int t = int.Parse(isr.ReadLine());

        for (int i = 0; i < t; i++)
        {
            int n = int.Parse(isr.ReadLine());
            int[] ab = isr.ReadLine().Split().Select(int.Parse).ToArray();
            int a = ab[0];
            int b = ab[1];

            for (int j = 0; j < n; j++)
            {
                int[] uv = isr.ReadLine().Split().Select(int.Parse).ToArray();
                int u = uv[0];
                int v = uv[1];
            }

            Console.WriteLine("Material Management {0}", i + 1);
            Console.WriteLine("Classification ---- End!");
        }
    }
}