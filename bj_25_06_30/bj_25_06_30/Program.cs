internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        while (true)
        {
            string str = isr.ReadLine();
            if (str == "***")
            {
                break;
            }

            str = new string(str.Reverse().ToArray());

            Console.WriteLine(str);
        }
    }
}