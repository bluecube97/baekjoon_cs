internal class Program
{
    static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine());

        for (int i = 0; i < T; i++)
        {
            string str = Console.ReadLine();

            if (str.Length != 7)
            {
                Console.WriteLine(0);
                continue;
            }

            char c1 = str[0];
            char c2 = str[2];

            if (str[0] == c1 && str[1] == c1 && str[2] == c2 && str[3] == c2 && str[4] == c1 && str[5] == c2 &&
                 str[6] == c2 && c1 != c2)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}