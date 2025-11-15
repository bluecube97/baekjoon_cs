internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        string file = isr.ReadLine();
        string result = isr.ReadLine();

        if (n % 2 == 0 && file.Equals(result))
        {
            Console.WriteLine("Deletion succeeded");
        }
        else if (n % 2 == 0)
        {
            Console.WriteLine("Deletion failed");
        }
        else if (n % 2 == 1)
        {
            for (int i = 0; i < file.Length; i++)
            {
                if (file[i].Equals(result[i]))
                {
                    Console.WriteLine("Deletion failed");
                    return;
                }
            }

            Console.WriteLine("Deletion succeeded");
        }
    }
}