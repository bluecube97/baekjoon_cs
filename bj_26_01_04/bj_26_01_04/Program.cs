internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int[] input = isr.ReadLine().Split().Select(int.Parse).ToArray();
            int a = input[0];
            int b = input[1];

            Console.WriteLine(a < b ? "NO BRAINS" : "MMM BRAINS");
        }
    }
}