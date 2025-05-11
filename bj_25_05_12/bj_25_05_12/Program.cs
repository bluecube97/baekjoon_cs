internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] abc = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int a = abc[0];
        int b = abc[1];
        int c = abc[2];
        int t = int.Parse(isr.ReadLine());

        if (t <= 30)
        {
            Console.WriteLine(a);
        }
        else
        {
            int time = t - 30;
            int charge = a + time / b * c;

            if (time % b != 0)
            {
                charge += c;
            }

            Console.WriteLine(charge);
        }
    }
}