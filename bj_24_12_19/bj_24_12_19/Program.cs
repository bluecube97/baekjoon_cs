internal class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int birthYear = input[0];
        int birthMonth = input[1];
        int birthDay = input[2];

        input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int currentYear = input[0];
        int currentMonth = input[1];
        int currentDay = input[2];

        int manAge = currentYear - birthYear;
        if (currentMonth < birthMonth || (currentMonth == birthMonth && currentDay < birthDay))
        {
            manAge--;
        }

        int koreaAge = currentYear - birthYear + 1;
        int yearAge = currentYear - birthYear;

        Console.WriteLine(manAge);
        Console.WriteLine(koreaAge);
        Console.WriteLine(yearAge);
    }
}