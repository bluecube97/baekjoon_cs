internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int t = int.Parse(isr.ReadLine());

        for (int i = 0; i < t; i++)
        {
            string a = isr.ReadLine();
            string b = isr.ReadLine();

            int hammingDistance = 0;
            int len = a.Length;

            for (int j = 0; j < len; j++)
            {
                if (a[j] != b[j])
                {
                    hammingDistance++;
                }
            }

            Console.WriteLine("Hamming distance is {0}.", hammingDistance);
        }
    }
}