internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        string book = isr.ReadLine();

        int sum = 0;
        int starWeight = 0;

        for (int i = 0; i < 13; i++)
        {
            if (book[i] != '*')
            {
                if (i % 2 == 0)
                {
                    sum += book[i] - '0';
                }
                else
                {
                    sum += (book[i] - '0') * 3;
                }
            }
            else
            {
                if (i % 2 == 0)
                {
                    starWeight = 1;
                }
                else
                {
                    starWeight = 3;
                }
            }
        }

        for (int i = 0; i < 10; i++)
        {
            int tempSum = sum + starWeight * i;

            if (tempSum % 10 == 0)
            {
                Console.WriteLine(i);
                return;
            }
        }
    }
}