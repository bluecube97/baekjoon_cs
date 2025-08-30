internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int year = int.Parse(isr.ReadLine()) - 3;

        if (year == 0)
        {
            Console.WriteLine("L9");
            return;
        }
        if (year == -1)
        {
            Console.WriteLine("K8");
            return;
        }
        if (year == -2)
        {
            Console.WriteLine("J7");
            return;
        }

        int twelveji = (year - 1) % 12;
        int tengan = (year - 1) % 10;

        string a = ((char) (twelveji + 'A')).ToString();
        Console.WriteLine(a + tengan);
    }
}