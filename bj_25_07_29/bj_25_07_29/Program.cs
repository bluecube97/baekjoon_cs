internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string T = isr.ReadLine();
            int TSize = T.Length;
            if (T[TSize / 2].Equals(T[TSize / 2 - 1]))
            {
                Console.WriteLine("Do-it");
            }
            else
            {
                Console.WriteLine("Do-it-Not");
            }
        }
    }
}