internal class Program
{
    static void Main(string[] args)
    {
        char alphabet = Console.ReadLine()[0];

        if (alphabet == 'N' || alphabet == 'n')
        {
            Console.WriteLine("Naver D2");
        }
        else
        {
            Console.WriteLine("Naver Whale");
        }
    }
}