internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] attArr = new int[31];

        for (int i = 0; i < 28; i++)
        {
            int n = int.Parse(isr.ReadLine());
            attArr[n] = 1;
        }

        for (int i = 1; i <= 30; i++)
        {
            if (attArr[i] == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}