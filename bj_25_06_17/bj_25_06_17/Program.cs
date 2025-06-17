internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int t = int.Parse(isr.ReadLine());

        for (int i = 0; i < t; i++)
        {
            int[] gandalf = isr.ReadLine().Split().Select(int.Parse).ToArray();
            int[] sauron = isr.ReadLine().Split().Select(int.Parse).ToArray();

            int gandalfPoint = gandalf[0] * 1 + gandalf[1] * 2 + gandalf[2] * 3
                               + gandalf[3] * 3 + gandalf[4] * 4 + gandalf[5] * 10;
            int sauronPoint = sauron[0] * 1 + sauron[1] * 2 + sauron[2] * 2
                               + sauron[3] * 2 + sauron[4] * 3 + sauron[5] * 5 + sauron[6] * 10;

            Console.Write("Battle {0}: ", i + 1);

            if (gandalfPoint > sauronPoint)
            {
                Console.WriteLine("Good triumphs over Evil");
            }
            else if (gandalfPoint < sauronPoint)
            {
                Console.WriteLine("Evil eradicates all trace of Good");
            }
            else
            {
                Console.WriteLine("No victor on this battle field");
            }
        }
    }
}