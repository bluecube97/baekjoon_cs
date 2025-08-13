internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        string ab = isr.ReadLine();
        int a, b;

        if (ab[0] == '1' && ab[1] == '0')
        {
            a = 10;
            if (ab.Length == 3)
            {
                b = int.Parse(ab[2].ToString());
            }
            else
            {
                b = 10;
            }
        }
        else
        {
            a = int.Parse(ab[0].ToString());
            if (ab.Length == 2)
            {
                b = int.Parse(ab[1].ToString());
            }
            else
            {
                b = 10;
            }
        }

        Console.WriteLine(a + b);
    }
}