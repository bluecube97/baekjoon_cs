internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        string shinei = "";
        List<string> region = new List<string>();

        for (int i = 0; i < n; i++)
        {
            int[] input = isr.ReadLine().Split().Select(int.Parse).ToArray();

            for (int j = 0; j < n; j++)
            {
                if (input[j] == 1)
                {
                    region.Add((i + j) % 2 == 0 ? "W" : "B");
                }
                else if (input[j] == 2)
                {
                    shinei = (i + j) % 2 == 0 ? "W" : "B";
                }
            }
        }

        if (region.Contains(shinei))
        {
            Console.WriteLine("Kiriya");
        }
        else
        {
            Console.WriteLine("Lena");
        }
    }
}