internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int l = int.Parse(isr.ReadLine());
        int a = int.Parse(isr.ReadLine());
        int b = int.Parse(isr.ReadLine());
        int c = int.Parse(isr.ReadLine());
        int d = int.Parse(isr.ReadLine());

        int kor = 0;
        int math = 0;

        if (a % c == 0)
        {
            kor = a / c;
        }
        else
        {
            kor = a / c + 1;
        }

        if (b % d == 0)
        {
            math = b / d;
        }
        else
        {
            math = b / d + 1;
        }

        Console.WriteLine(l - Math.Max(kor, math));
    }
}