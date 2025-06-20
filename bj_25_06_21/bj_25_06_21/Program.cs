internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        int[] arr = isr.ReadLine().Split().Select(int.Parse).ToArray();

        int odd = 0; // 홀수
        int even = 0; // 짝수

        foreach (var el in arr)
        {
            if (el % 2 == 0)
            {
                even++;
            }
            else
            {
                odd++;
            }
        }

        if (n % 2 == 0)
        {
            if (odd == even)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
        else
        {
            if (odd == even + 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }

    }
}