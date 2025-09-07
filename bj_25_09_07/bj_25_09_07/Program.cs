internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] finger = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int jun = finger[0];
        int ik = finger[1];

        if (jun != 0 && jun != 2 && jun != 5 && ik != 0 && ik != 2 && ik != 5)
        {
            Console.WriteLine("=");
            return;
        }

        if (jun != 0 && jun != 2 && jun != 5)
        {
            Console.WriteLine("<");
            return;
        }

        if (ik != 0 && ik != 2 && ik != 5)
        {
            Console.WriteLine(">");
            return;
        }

        if (jun == ik)
        {
            Console.WriteLine("=");
            return;
        }

        if ((jun == 0 && ik == 2) || (jun == 2 && ik == 5) || (jun == 5 && ik == 0))
        {
            Console.WriteLine(">");
        }
        else
        {
            Console.WriteLine("<");
        }
    }
}