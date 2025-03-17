internal class Program
{
    static void Main(string[] args)
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int t = int.Parse(isr.ReadLine());

        for (int i = 0; i < t; i++)
        {
            string num = isr.ReadLine();
            int count = 0;

            while (true)
            {
                if (num.Equals("6174"))
                {
                    Console.WriteLine(count);
                    break;
                }

                char[] numArr = num.ToArray();
                Array.Sort(numArr);
                string a = new string(numArr);
                string b = new string(numArr.Reverse().ToArray());

                num = Math.Abs(int.Parse(b) - int.Parse(a)).ToString().PadLeft(4, '0');
                count++;
            }
        }
    }
}