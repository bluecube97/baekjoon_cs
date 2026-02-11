internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());

        string prev = string.Empty;

        while (true)
        {
            prev = isr.ReadLine();
            if (prev.Length == 3)
                break;
            n--;
        }

        for (int i = 1; i < n; i++)
        {
            string name = isr.ReadLine();
            if (name.Length != 3)
                continue;

            if (string.Compare(prev, name) > 0)
            {
                prev = name;
            }
        }

        Console.WriteLine(prev);
    }
}