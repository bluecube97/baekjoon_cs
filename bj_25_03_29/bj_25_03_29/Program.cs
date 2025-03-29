internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        while (isr.Peek() >= 0)
        {
            string str = isr.ReadLine();

            int small = 0;
            int big = 0;
            int num = 0;
            int space = 0;

            foreach (char c in str)
            {
                if (c >= 'a' && c <= 'z')
                {
                    small++;
                }
                else if (c >= 'A' && c <= 'Z')
                {
                    big++;
                }
                else if (c >= '0' && c <= '9')
                {
                    num++;
                }
                else if (c == ' ')
                {
                    space++;
                }
            }

            Console.WriteLine($"{small} {big} {num} {space}");
        }
    }
}