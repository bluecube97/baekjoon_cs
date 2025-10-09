internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        string nowQuestion = "A";
        int a = 0;
        int b = 0;

        for (int i = 1; i < 10; i++)
        {
            Console.WriteLine("? {0} {1}", nowQuestion, i);
            Console.Out.Flush();
            int ans = int.Parse(isr.ReadLine());

            if (ans == 1 && nowQuestion == "A")
            {
                nowQuestion = "B";
                a = i;
                i = 0;
            }
            else if (ans == 1 && nowQuestion == "B")
            {
                b = i;
                break;
            }
        }

        Console.WriteLine("! {0}", a + b);
    }
}