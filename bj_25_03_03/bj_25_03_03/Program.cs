using System.Text;

internal class Program
{
    static void Main(string[] args)
    {
        var sir = new StreamReader(Console.OpenStandardInput());
        int n = int.Parse(sir.ReadLine());
        int count = 0;

        for (int i = 2023; i <= n; i++)
        {
            int serialCount = 0;
            string serial = i.ToString();

            foreach (var num in serial)
            {
                if (serialCount == 0 && num == '2')
                {
                    serialCount++;
                }
                else if (serialCount == 1 && num == '0')
                {
                    serialCount++;
                }
                else if (serialCount == 2 && num == '2')
                {
                    serialCount++;
                }
                else if (serialCount == 3 && num == '3')
                {
                    serialCount++;
                }
            }

            if (serialCount == 4)
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}