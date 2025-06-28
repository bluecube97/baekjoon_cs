internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());

        while (true)
        {
            int num = int.Parse(isr.ReadLine());
            if (num == 0)
                break;

            if (num % n != 0)
            {
                Console.WriteLine("{0} is NOT a multiple of {1}.", num, n);
            }
            else
            {
                Console.WriteLine("{0} is a multiple of {1}.", num, n);
            }
        }
    }
}