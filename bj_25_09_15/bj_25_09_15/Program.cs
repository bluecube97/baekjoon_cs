internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        string k = isr.ReadLine();

        int hol = 0;
        int jjak = 0;

        for (int i = 0; i < n; i++)
        {
            if (int.Parse(k[i].ToString()) % 2 == 0)
            {
                jjak++;
            }
            else
                hol++;
        }

        if (hol == jjak)
        {
            Console.WriteLine(-1);
            return;
        }

        Console.WriteLine(hol > jjak ? 1 : 0);
    }
}