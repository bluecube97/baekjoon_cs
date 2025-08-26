internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int x = int.Parse(isr.ReadLine());
        int n = int.Parse(isr.ReadLine());

        int priceSum = 0;

        for (int i = 0; i < n; i++)
        {
            int[] bill = isr.ReadLine().Split().Select(int.Parse).ToArray();
            int price = bill[0];
            int ea = bill[1];

            int total = price * ea;
            priceSum += total;
        }

        Console.WriteLine(priceSum == x ? "Yes" : "No");
    }
}