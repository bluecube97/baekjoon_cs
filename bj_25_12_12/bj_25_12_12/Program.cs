internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int l = int.Parse(isr.ReadLine());

        double area = (Math.Sqrt(3) / 4) * l * l;

        Console.WriteLine($"{area:0.#########}");
    }
}