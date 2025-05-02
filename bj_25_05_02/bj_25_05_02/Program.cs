internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] corrAns = new int[10];

        for (int i = 1; i <= 10; i++)
        {
            corrAns[i - 1] = (i - 1) % 5 + 1;
        }

        int n = int.Parse(isr.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int[] answer = isr.ReadLine().Split().Select(int.Parse).ToArray();
            if (answer.SequenceEqual(corrAns))
            {
                Console.WriteLine(i + 1);
            }
        }
    }
}