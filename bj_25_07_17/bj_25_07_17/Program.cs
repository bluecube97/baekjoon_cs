internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        while (true)
        {
            int[] input = isr.ReadLine().Split().Select(int.Parse).ToArray();
            if (input[0] == 0 && input[1] == 0)
                break;

            int m = input[0];
            int f = input[1];

            Console.WriteLine(m + f);
        }
    }
}