internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int t = int.Parse(isr.ReadLine());

        for (int i = 0; i < t; i++)
        {
            int[] arr = isr.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            int min = int.MaxValue;

            foreach (var num in arr)
            {
                if (num % 2 == 0)
                {
                    sum += num;

                    if (num < min)
                    {
                        min = num;
                    }
                }
            }

            Console.Write(sum + " ");
            Console.WriteLine(min);
        }
    }
}