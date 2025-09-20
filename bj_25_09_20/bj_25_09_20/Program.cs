internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int t = int.Parse(isr.ReadLine());

        for (int i = 0; i < t; i++)
        {
            string str = isr.ReadLine();

            str = str.Replace("PO", "PHO");
            Console.WriteLine(str);
        }
    }
}