internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            int[] input = isr.ReadLine().Split().Select(int.Parse).ToArray();
            int people = input[0];
            int apple = input[1];

            sum += apple % people;
        }

        Console.WriteLine(sum);
    }
}