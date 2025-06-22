internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        float prev = -20;

        while (true)
        {
            float temp = float.Parse(isr.ReadLine());

            if (temp == 999)
            {
                break;
            }

            if (prev != -20)
            {
                Console.WriteLine("{0:F2}", temp - prev);
            }
            prev = temp;
        }
    }
}