internal class Program
{
    static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());

        for (int i = 0; i < t; i++)
        {
            string creditCard = Console.ReadLine();
            int[] numArr = new int[16];

            for (int j = 0; j < 16; j++)
            {
                numArr[j] = int.Parse(creditCard[j].ToString());
            }

            for (int j = 14; j >= 0; j -= 2)
            {
                int num = numArr[j] * 2;
                if (num >= 10)
                {
                    num = num / 10 + num % 10;
                }
                numArr[j] = num;
            }

            int sum = 0;
            for (int j = 0; j < 16; j++)
            {
                sum += numArr[j];
            }

            if (sum % 10 == 0)
            {
                Console.WriteLine("T");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}