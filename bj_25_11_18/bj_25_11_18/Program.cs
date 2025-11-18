internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        string s = isr.ReadLine();

        switch (s)
        {
            case "fdsajkl;":
                Console.WriteLine("in-out");
                break;
            case "jkl;fdsa":
                Console.WriteLine("in-out");
                break;
            case "asdf;lkj":
                Console.WriteLine("out-in");
                break;
            case ";lkjasdf":
                Console.WriteLine("out-in");
                break;
            case "asdfjkl;":
                Console.WriteLine("stairs");
                break;
            case ";lkjfdsa":
                Console.WriteLine("reverse");
                break;
            default:
                Console.WriteLine("molu");
                break;
        }
    }
}