internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string line = isr.ReadLine();

            if (line.Contains("Simon says"))
            {
                string response = line.Substring("Simon says".Length);
                Console.WriteLine(response);
            }
        }
    }
}