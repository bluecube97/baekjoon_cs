internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        while (true)
        {
            string[] input = isr.ReadLine().Split();
            string a = input[0];
            string b = input[1];

            if (a == "0" && b == "0")
            {
                break;
            }

            int i = a.Length - 1;
            int j = b.Length - 1;
            int carry = 0;
            int carryCount = 0;

            while (i >= 0 || j >= 0)
            {
                int digitA = i >= 0 ? a[i] - '0' : 0;
                int digitB = j >= 0 ? b[j] - '0' : 0;

                if (digitA + digitB + carry >= 10)
                {
                    carryCount++;
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }

                i--;
                j--;
            }

            Console.WriteLine(carryCount);
        }
    }
}