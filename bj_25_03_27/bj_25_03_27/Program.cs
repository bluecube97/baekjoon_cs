internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        string maxSeminar = "";
        int maxPeople = int.MinValue;

        for (int i = 0; i < 7; i++)
        {
            string[] input = isr.ReadLine().Split();
            string seminar = input[0];
            int people = int.Parse(input[1]);

            if (people > maxPeople)
            {
                maxPeople = people;
                maxSeminar = seminar;
            }
        }

        Console.WriteLine(maxSeminar);
    }
}