internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        string[] words = isr.ReadLine().Split();

        foreach (var s in words)
        {
            Console.Write(s + "DORO ");
        }
    }
}