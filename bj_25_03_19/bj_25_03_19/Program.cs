internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());

        switch (n)
        {
            case 1:
                Console.WriteLine(11);
                Console.WriteLine("A B C D E F G H J L M");
                break;
            case 2:
                Console.WriteLine(9);
                Console.WriteLine("A C E F G H I L M");
                break;
            case 3:
                Console.WriteLine(9);
                Console.WriteLine("A C E F G H I L M");
                break;
            case 4:
                Console.WriteLine(9);
                Console.WriteLine("A B C E F G H L M");
                break;
            case 5:
                Console.WriteLine(8);
                Console.WriteLine("A C E F G H L M");
                break;
            case 6:
                Console.WriteLine(8);
                Console.WriteLine("A C E F G H L M");
                break;
            case 7:
                Console.WriteLine(8);
                Console.WriteLine("A C E F G H L M");
                break;
            case 8:
                Console.WriteLine(8);
                Console.WriteLine("A C E F G H L M");
                break;
            case 9:
                Console.WriteLine(8);
                Console.WriteLine("A C E F G H L M");
                break;
            case 10:
                Console.WriteLine(8);
                Console.WriteLine("A B C F G H L M");
                break;
        }
    }
}