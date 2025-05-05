internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int x = int.Parse(isr.ReadLine());

        for (int i = x + 1; i < 10000; i++)
        {
            string strX = i.ToString();
            int a = int.Parse(strX[..2]);
            int b = int.Parse(strX[2..]);

            if ((a + b) * (a + b) == i)
            {
                Console.WriteLine(i);
                return;
            }
        }

        Console.WriteLine(-1);
    }
}