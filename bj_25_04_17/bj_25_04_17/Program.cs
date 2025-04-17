internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        string str = isr.ReadLine();
        int len = str.Length;

        string front;
        if (len % 2 == 0)
        {
            front = str.Substring(0, len / 2);
        }
        else
        {
            front = str.Substring(0, len / 2 + 1);
        }

        string back = str.Substring(len / 2, len - len / 2);
        back = new string(back.Reverse().ToArray());

        if (front == back)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}