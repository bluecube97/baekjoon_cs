internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int a = int.Parse(isr.ReadLine());
        int b = int.Parse(isr.ReadLine());
        int c = int.Parse(isr.ReadLine());
        int d = int.Parse(isr.ReadLine());

        if ((a == 8 || a == 9) && (d == 8 || d == 9) && b == c)
        {
            Console.WriteLine("ignore");
        }
        else
        {
            Console.WriteLine("answer");
        }
    }
}