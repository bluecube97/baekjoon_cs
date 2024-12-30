internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int left = 1, right = n;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            int total = 1 + mid + mid * mid;

            if (total == n)
            {
                Console.WriteLine(mid);
                return;
            }
            else if (total < n)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
    }
}