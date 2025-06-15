internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine()!);

        for (int i = 0; i < n; i++)
        {
            string line = isr.ReadLine();
            if (line[0] >= 'A' && line[0] <= 'Z')
            {
                Console.Write(line[0]);
            }
            else
            {
                Console.Write((char)(line[0] - ('a' - 'A')));
            }
            Console.WriteLine(line[1..]);
        }
    }
}