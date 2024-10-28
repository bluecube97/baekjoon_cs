internal class Program
{
    static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine());

        int A = 0;
        int B = 0;
        int C = 0;

        if (T % 300 != 0 && T % 60 != 0 && T % 10 != 0)
        {
            Console.WriteLine(-1);
        }
        else
        {
            if (T >= 300)
            {
                A = T / 300;
                T %= 300;
            }

            if (T >= 60)
            {
                B = T / 60;
                T %= 60;
            }

            if (T >= 10)
            {
                C = T / 10;
                T %= 10;
            }
            Console.WriteLine(A + " " + B + " " + C);
        }
    }
}