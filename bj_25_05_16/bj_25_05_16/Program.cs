internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int t = int.Parse(isr.ReadLine());

        for (int i = 0; i < t; i++)
        {
            int[] arr = isr.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(arr.Sum());
        }
    }
}