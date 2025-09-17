internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int t = int.Parse(isr.ReadLine());
        int n = int.Parse(isr.ReadLine());
        int[] f = isr.ReadLine().Split().Select(int.Parse).ToArray();

        Console.WriteLine(t <= f.Sum() ? "Padaeng_i Happy" : "Padaeng_i Cry");
    }
}