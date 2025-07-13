internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("String #{0}", i + 1);
            string name = isr.ReadLine();

            foreach (var c in name)
            {
                if (c == 'Z')
                {
                    Console.Write('A');
                }
                else
                {
                    Console.Write((char)(c + 1));
                }
            }
            Console.WriteLine();
            if (i < n - 1)
            {
                Console.WriteLine();
            }
        }
    }
}