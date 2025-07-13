internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());
        int i = 1;

        while (true)
        {
            int[] abc = isr.ReadLine().Split().Select(int.Parse).ToArray();
            if (abc[0] == 0 && abc[1] == 0 && abc[2] == 0)
                break;

            if (i != 1)
                Console.WriteLine();

            Console.WriteLine("Triangle #{0}", i);
            i++;

            int a = abc[0];
            int b = abc[1];
            int c = abc[2];

            if (a == -1)
            {
                if (c <= b)
                {
                    Console.WriteLine("Impossible.");
                    continue;
                }
                double val = Math.Sqrt(c * c - b * b);
                if (double.IsNaN(val) || val <= 0)
                {
                    Console.WriteLine("Impossible.");
                }
                else
                {
                    Console.WriteLine($"a = {val:F3}");
                }
            }
            else if (b == -1)
            {
                if (c <= a)
                {
                    Console.WriteLine("Impossible.");
                    continue;
                }
                double val = Math.Sqrt(c * c - a * a);
                if (double.IsNaN(val) || val <= 0)
                {
                    Console.WriteLine("Impossible.");
                }
                else
                {
                    Console.WriteLine($"b = {val:F3}");
                }
            }
            else if (c == -1)
            {
                double val = Math.Sqrt(a * a + b * b);
                if (double.IsNaN(val) || val <= 0)
                {
                    Console.WriteLine("Impossible.");
                }
                else
                {
                    Console.WriteLine($"c = {val:F3}");
                }
            }
        }
    }
}