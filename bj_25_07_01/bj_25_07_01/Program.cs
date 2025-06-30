internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());
        int index = 1;

        while (true)
        {
            int n0 = int.Parse(isr.ReadLine());
            if (n0 == 0)
            {
                break;
            }

            int n1 = n0 * 3;
            int n2;
            if (n1 % 2 == 0)
            {
                n2 = n1 / 2;
            }
            else
            {
                n2 = (n1 + 1) / 2;
            }

            int n3 = n2 * 3;
            int n4 = n3 / 9;

            if (n1 % 2 == 0)
            {
                Console.WriteLine("{0}. even {1}", index, n4);
            }
            else
            {
                Console.WriteLine("{0}. odd {1}", index, n4);
            }

            index++;
        }
    }
}