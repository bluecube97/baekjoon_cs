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
            if (i % 2 == 0)
            {
                for (int j = 0; j < n * 2; j++)
                {
                    Console.Write(j % 2 == 0 ? "*" : " ");
                }
            }
            else
            {
                for (int j = 0; j < n * 2; j++)
                {
                    Console.Write(j % 2 == 0 ? " " : "*");
                }
            }
            Console.WriteLine();
        }
    }
}