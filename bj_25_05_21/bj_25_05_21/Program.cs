using System.Text;

internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());
        StringBuilder sb = new StringBuilder();

        int n = int.Parse(isr.ReadLine());
        int A = 0;
        int B = 0;

        for (int i = 0; i < n; i++)
        {
            int[] ab = isr.ReadLine().Split().Select(int.Parse).ToArray();
            int a = ab[0];
            int b = ab[1];

            A += a;
            B += b;

            sb.Append(A - B);
            sb.AppendLine();
        }

        Console.WriteLine(sb.ToString());
    }
}