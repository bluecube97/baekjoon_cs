internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] nm = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int n = nm[0];
        int m = nm[1];

        int answer = 1;

        for (int i = 0; i < n; i++)
        {
            int a = int.Parse(isr.ReadLine());

            if (a == 0)
            {
                continue;
            }

            answer *= a;
            answer %= m;
        }

        answer %= m;
        Console.WriteLine(answer);
    }
}