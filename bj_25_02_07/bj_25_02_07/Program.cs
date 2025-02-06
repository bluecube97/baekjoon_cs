internal class Program
{
    static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());

        for (int i = 0; i < t; i++)
        {
            string num = Console.ReadLine();
            char[] reverseArr = num.ToCharArray();
            Array.Reverse(reverseArr);
            string reverse = new string(reverseArr);
            string sum = (int.Parse(num) + int.Parse(reverse)).ToString();
            bool isSymmetric = true;

            for (int j = 0; j < sum.Length / 2; j++)
            {
                if (sum[j] != sum[sum.Length - 1 - j])
                {
                    Console.WriteLine("NO");
                    isSymmetric = false;
                    break;
                }
            }

            if (isSymmetric)
            {
                Console.WriteLine("YES");
            }
        }
    }
}