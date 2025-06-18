internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] testCase = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int s1 = testCase[0];
        int s2 = testCase[1];

        for (int i = 0; i < s1; i++)
        {
            int[] input = isr.ReadLine().Split().Select(int.Parse).ToArray();
            int cor = input[0];
            int ans = input[1];

            if (cor != ans)
            {
                Console.WriteLine("Wrong Answer");
                return;
            }
        }

        for (int i = 0; i < s2; i++)
        {
            int[] input = isr.ReadLine().Split().Select(int.Parse).ToArray();
            int cor = input[0];
            int ans = input[1];

            if (cor != ans)
            {
                Console.WriteLine("Why Wrong!!!");
                return;
            }
        }

        Console.WriteLine("Accepted");
    }
}