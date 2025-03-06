internal class Program
{
    static void Main(string[] args)
    {
        var isr = new StreamReader(Console.OpenStandardInput());
        int n = int.Parse(isr.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string name = isr.ReadLine();
            bool isFirst = true;
            Console.Write("god");

            foreach (var c in name)
            {
                if (!isFirst)
                {
                    if (c != ' ')
                    {
                        Console.Write(c);
                    }
                }
                else if (c == ' ')
                {
                    isFirst = false;
                }
            }
            Console.WriteLine();
        }
    }
}