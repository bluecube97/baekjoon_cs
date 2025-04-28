internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] input = isr.ReadLine().Split().Select(int.Parse).ToArray();

        int l = input[0];
        int r = input[1];
        int a = input[2];

        for (int i = 0; i < a; i++)
        {
            if (l > r)
            {
                r++;
            }
            else
            {
                l++;
            }
        }

        if (l > r)
        {
            Console.WriteLine(r * 2);
        }
        else
        {
            Console.WriteLine(l * 2);
        }
    }
}