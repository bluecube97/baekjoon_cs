internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        while (true)
        {
            int[] bn = isr.ReadLine().Split().Select(int.Parse).ToArray();
            int b = bn[0];
            int n = bn[1];

            if (b == 0 && n == 0)
                break;
            
            int prev = 0;

            for (int i = 1; i <= 1000000; i++)
            {
                int pow = (int) Math.Pow(i, n);
                if (b <= pow)
                {
                    if (Math.Abs(prev - b) > Math.Abs(pow - b))
                    {
                        Console.WriteLine(i);
                        break;
                    }
                    else
                    {
                        Console.WriteLine(i - 1);
                        break;
                    }
                }
                prev = pow;
            }
        }
    }
}