internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int t = int.Parse(isr.ReadLine());

        for (int i = 0; i < t; i++)
        {
            int n = int.Parse(isr.ReadLine());
            int hor = n / 5;
            int ver = n % 5;

            for (int j = 0; j < hor; j++)
            {
                Console.Write("++++ ");
            }

            for (int j = 0; j < ver; j++)
            {
                Console.Write("|");
            }

            Console.WriteLine();
        }
    }
}