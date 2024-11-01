internal class Program
{
    static void Main(string[] args)
    {
        int star = int.Parse(Console.ReadLine());

        for (int i = 0; i < star; i++)
        {
            for (int j = star - i - 1; j > 0; j--)
            {
                Console.Write(" ");
            }
            Console.Write("*");

            for (int j = 0; j < i; j++)
            {
                Console.Write(" *");
            }

            if (i == star - 1) break;
            Console.WriteLine();
        }
    }
}