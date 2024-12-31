internal class Program
{
    static void Main(string[] args)
    {
        int k = int.Parse(Console.ReadLine());
        double[] D = Console.ReadLine().Split().Select(double.Parse).ToArray();
        double d1 = D[0];
        double d2 = D[1];

        double hSquare =  (k * k) - Math.Abs((d1 - d2) / 2) * Math.Abs((d1 - d2) / 2);
        Console.WriteLine(hSquare);
    }
}