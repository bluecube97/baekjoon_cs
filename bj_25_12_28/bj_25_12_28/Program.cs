internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());

        if (n == 1)
        {
            Console.WriteLine("*");
            return;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(j % 2 == 0 ? "*" : " ");
            }
            Console.WriteLine();
            for (int j = 0; j < n; j++)
            {
                Console.Write(j % 2 == 0 ? " " : "*");
            }
            Console.WriteLine();
        }
    }
}