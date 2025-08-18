internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        List<int> science = new List<int>();
        List<int> social = new List<int>();

        for (int i = 0; i < 4; i++)
        {
            science.Add(int.Parse(isr.ReadLine()));
        }
        for (int i = 0; i < 2; i++)
        {
            social.Add(int.Parse(isr.ReadLine()));
        }

        science.Sort();
        social.Sort();

        int total = science[1] + science[2] + science[3] + social[1];

        Console.WriteLine(total);
    }
}