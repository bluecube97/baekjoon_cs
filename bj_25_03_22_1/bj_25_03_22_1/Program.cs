internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int t = int.Parse(isr.ReadLine());
        int[] numArr = isr.ReadLine().Split().Select(int.Parse).ToArray();
        for (int i = 0; i < t; i++)
        {
            int num = numArr[i];
            List<int> divisors = getDivisor(num);

            if (divisors.Sum() == num)
            {
                Console.WriteLine("Perfect");
            }
            else if (divisors.Sum() < num)
            {
                Console.WriteLine("Deficient");
            }
            else
            {
                Console.WriteLine("Abundant");
            }
        }
    }

    private static List<int> getDivisor(int num)
    {
        List<int> divisors = new List<int>();
        for (int i = 1; i < num; i++)
        {
            if (num % i == 0)
            {
                divisors.Add(i);
            }
        }
        return divisors;
    }
}