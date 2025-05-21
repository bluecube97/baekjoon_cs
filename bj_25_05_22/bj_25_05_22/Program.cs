using System.Text;

internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());
        StringBuilder sb = new StringBuilder();

        int t = int.Parse(isr.ReadLine());

        for (int i = 0; i < t; i++)
        {
            string exp = isr.ReadLine();
            int logicalNotCount = 0;
            int factorialCount = 0;
            int num = 0;
            bool isFactorial = false;

            foreach (var el in exp)
            {
                if (el == '!' && !isFactorial)
                {
                    logicalNotCount++;
                }
                else if (el == '!' && isFactorial)
                {
                    factorialCount++;
                }
                else
                {
                    num = el == '0' ? 0 : 1;
                    isFactorial = true;
                }
            }

            if (factorialCount > 0)
            {
                num = 1;
            }

            if (logicalNotCount % 2 != 0)
            {
                num = num == 0 ? 1 : 0;
            }

            sb.Append(num);
            sb.AppendLine();
        }

        Console.Write(sb.ToString());
    }
}