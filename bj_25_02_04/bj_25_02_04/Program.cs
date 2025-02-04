internal class Program
{
    static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine());

        for (int i = 0; i < T; i++)
        {
            int d = int.Parse(Console.ReadLine());
            int t = 0;
            int s = 0;

            while (d >= t + s)
            {
                t++;
                s = t * t;
            }

            t--;
            Console.WriteLine(t);
        }
    }
}