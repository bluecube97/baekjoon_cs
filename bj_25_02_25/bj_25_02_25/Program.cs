internal class Program
{
    static void Main(string[] args)
    {
        int[] s = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] u = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int sPrice = s[0];
        int sWeight = s[1];
        int nPrice = n[0];
        int nWeight = n[1];
        int uPrice = u[0];
        int uWeight = u[1];

        double sCost = calcCost(sPrice, sWeight);
        double nCost = calcCost(nPrice, nWeight);
        double uCost = calcCost(uPrice, uWeight);

        List<double> cost = new List<double> { sCost, nCost, uCost };
        double min = cost.Max();
        if (min == sCost)
        {
            Console.WriteLine("S");
        }
        else if (min == nCost)
        {
            Console.WriteLine("N");
        }
        else
        {
            Console.WriteLine("U");
        }
    }

    private static double calcCost(int price, int weight)
    {
        int totalPrice = price * 10;
        if (totalPrice >= 5000)
        {
            totalPrice -= 500;
        }

        return (double)(weight * 10) / totalPrice;
    }
}