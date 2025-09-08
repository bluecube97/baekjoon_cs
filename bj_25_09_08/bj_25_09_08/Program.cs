internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        int[] menuPrices = new int[n];
        int priceSum = 0;

        for (int i = 0; i < n; i++)
        {
            int menuPrice = int.Parse(isr.ReadLine());
            menuPrices[i] = menuPrice;
        }

        int m = int.Parse(isr.ReadLine());

        for (int i = 0; i < m; i++)
        {
            int cornerNum = int.Parse(isr.ReadLine());
            priceSum += menuPrices[cornerNum - 1];
        }

        Console.WriteLine(priceSum);
    }
}