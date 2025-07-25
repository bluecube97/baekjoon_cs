internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        string num = isr.ReadLine();
        int count = 0;

        while (true)
        {
            int baseNum = 1;
            if (num.Length == 1)
            {
                Console.WriteLine(count);
                break;
            }
            foreach (var c in num)
            {
                baseNum *= int.Parse(c.ToString());
            }
            num = baseNum.ToString();
            count++;
        }
    }
}