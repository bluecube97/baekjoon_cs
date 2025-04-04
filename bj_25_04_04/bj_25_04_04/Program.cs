internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string carNum = isr.ReadLine();
            string first = carNum[..3];
            string second = carNum[4..8];

            int firstValue = 0;
            int secondValue = int.Parse(second);

            for (int j = 0; j < 3; j++)
            {
                firstValue += (first[j] - 'A') * (int) Math.Pow(26, 2 - j);
            }

            if (Math.Abs(firstValue - secondValue) <= 100)
            {
                Console.WriteLine("nice");
            }
            else
            {
                Console.WriteLine("not nice");
            }
        }
    }
}