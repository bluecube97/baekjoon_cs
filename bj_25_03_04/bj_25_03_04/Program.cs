internal class Program
{
    static void Main(string[] args)
    {
        var isr = new StreamReader(Console.OpenStandardInput());
        int n = int.Parse(isr.ReadLine());
        Console.WriteLine(GetFun(n));
    }

    private static int GetFun(int n)
    {
        if (n == 1)
        {
            return 0;
        }

        int a = n / 2;
        int b = n - a;
        int fun = a * b;

        return fun + GetFun(a) + GetFun(b);
    }
}