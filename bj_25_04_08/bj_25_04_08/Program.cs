internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        while (true)
        {
            int[] line = isr.ReadLine().Split().Select(int.Parse).ToArray();
            if (line[0] == 0 && line[1] == 0)
                break;

            int a = line[0];
            int b = line[1];

            int first = a / b;
            int second = a % b;

            Console.Write("{0} {1} / {2}", first, second, b);
            Console.WriteLine();
        }
    }
}