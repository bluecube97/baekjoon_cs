internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int count = 0;

        for (int i = 1; i <= n; i++)
        {
            string num = i.ToString();
            int sum = 0;

            for (int j = 0; j < num.Length; j++)
            {
                sum += num[j] - '0';
            }

            if (int.Parse(num) % sum == 0)
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}