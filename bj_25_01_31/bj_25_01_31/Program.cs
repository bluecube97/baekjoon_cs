internal class Program
{
    static void Main(string[] args)
    {
        string num = Console.ReadLine();
        int two = 0;
        int zero = 0;
        int one = 0;
        int eight = 0;

        foreach (var c in num)
        {
            if (c == '2')
            {
                two++;
            }
            else if (c == '0')
            {
                zero++;
            }
            else if (c == '1')
            {
                one++;
            }
            else if (c == '8')
            {
                eight++;
            }
            else
            {
                Console.WriteLine("0");
                return;
            }
        }

        if (two != 0 && zero != 0 && one != 0 && eight != 0)
        {
            if (two == zero && zero == one && one == eight)
            {
                Console.WriteLine("8");
            }
            else
            {
                Console.WriteLine("2");
            }
        }
        else
        {
            Console.WriteLine("1");
        }
    }
}