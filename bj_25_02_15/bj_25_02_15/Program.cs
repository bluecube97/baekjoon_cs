internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string time = Console.ReadLine();
            string[] timeParts = time.Split(':');
            int hours = int.Parse(timeParts[0]);
            int minutes = int.Parse(timeParts[1]);
            int seconds = int.Parse(timeParts[2]);

            string binaryHours = Convert.ToString(hours, 2).PadLeft(6, '0');
            string binaryMinutes = Convert.ToString(minutes, 2).PadLeft(6, '0');
            string binarySeconds = Convert.ToString(seconds, 2).PadLeft(6, '0');

            for (int j = 0; j < 6; j++)
            {
                Console.Write(binaryHours[j]);
                Console.Write(binaryMinutes[j]);
                Console.Write(binarySeconds[j]);
            }
            Console.Write(" ");
            Console.Write(binaryHours);
            Console.Write(binaryMinutes);
            Console.Write(binarySeconds);
            Console.WriteLine();
        }
    }
}