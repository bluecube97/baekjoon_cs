internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int t = int.Parse(isr.ReadLine());

        for (int i = 0; i < t; i++)
        {
            int n = int.Parse(isr.ReadLine());

            (string, int)[] univ = new (string, int)[n];

            for (int j = 0; j < n; j++)
            {
                string[] sl = isr.ReadLine().Split();
                string s = sl[0];
                int l = int.Parse(sl[1]);

                univ[j] = (s, l);
            }

            Array.Sort(univ, (y, x) => x.Item2.CompareTo(y.Item2));
            Console.WriteLine(univ[0].Item1);
        }
    }
}