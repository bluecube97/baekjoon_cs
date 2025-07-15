internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Scenario #{0}:", i + 1);

            int[] input = isr.ReadLine().Split().Select(int.Parse).ToArray();
            int a = input[0];
            int b = input[1];
            int c = input[2];

            if (a * a + b * b == c * c ||
                a * a + c * c == b * b ||
                b * b + c * c == a * a)
            {
                Console.WriteLine("yes");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine();
            }
        }
    }
}