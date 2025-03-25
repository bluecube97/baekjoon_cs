internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());
        
        while (true)
        {
            string line = isr.ReadLine();
            if (line.Equals("END"))
            {
                break;
            }

            Console.WriteLine(line.Reverse().ToArray());
        }
    }
}