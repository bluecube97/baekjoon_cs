internal class Program
{
    static void Main(string[] args)
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] nxk = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int n = nxk[0];
        int x = nxk[1];
        int k = nxk[2];

        bool[] ball = new bool[n + 1];
        ball[x] = true;

        for (int i = 0; i < k; i++)
        {
            int[] input = isr.ReadLine().Split().Select(int.Parse).ToArray();
            int a = input[0];
            int b = input[1];

            if (ball[a])
            {
                ball[a] = false;
                ball[b] = true;
            }
            else if (ball[b])
            {
                ball[b] = false;
                ball[a] = true;
            }
        }

        for (int i = 1; i <= n; i++)
        {
            if (ball[i])
            {
                Console.WriteLine(i);
            }
        }
    }
}