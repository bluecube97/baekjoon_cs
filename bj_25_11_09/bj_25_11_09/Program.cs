internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        int count = 0;

        for (int i = 1; i < n; i++)
        {
            if (i.ToString().Contains("50"))
            {
                count++;
            }
        }

        Console.WriteLine(count + n);
    }
}