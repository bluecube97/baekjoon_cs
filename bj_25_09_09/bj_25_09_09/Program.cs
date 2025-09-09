internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        string retake = isr.ReadLine();
        retake = retake[..5];
        int n = int.Parse(isr.ReadLine());
        int canRetake = 0;

        for (int i = 0; i < n; i++)
        {
            string course = isr.ReadLine();
            course = course[..5];

            if (retake == course)
            {
                canRetake++;
            }
        }

        Console.WriteLine(canRetake);
    }
}