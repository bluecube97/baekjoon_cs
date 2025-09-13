using System.Text;

internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());
        StringBuilder sb = new StringBuilder();

        int n = int.Parse(isr.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n * 5; j++)
            {
                sb.Append('@');
            }
            sb.Append('\n');
        }

        for (int i = 0; i < n * 3; i++)
        {
            for (int j = 0; j < n; j++)
            {
                sb.Append('@');
            }
            for (int j = 0; j < n * 3; j++)
            {
                sb.Append(' ');
            }
            for (int j = 0; j < n; j++)
            {
                sb.Append('@');
            }
            sb.Append('\n');
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n * 5; j++)
            {
                sb.Append('@');
            }
            sb.Append('\n');
        }

        Console.WriteLine(sb.ToString());
    }
}