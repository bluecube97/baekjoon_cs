internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        while (true)
        {
            int[] line = isr.ReadLine().Split().Select(int.Parse).ToArray();

            int a = line[0];
            int b = line[1];

            if (a == 0 && b == 0)
                break;

            Console.WriteLine(a * 2 - b);
        }
    }
}