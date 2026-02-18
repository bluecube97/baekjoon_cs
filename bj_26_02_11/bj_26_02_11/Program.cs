internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] input = isr.ReadLine().Split().Select(int.Parse).ToArray();
        (int, int) bessie = (input[0], input[1]);
        input = isr.ReadLine().Split().Select(int.Parse).ToArray();
        (int, int) daisy = (input[0], input[1]);
        input = isr.ReadLine().Split().Select(int.Parse).ToArray();
        (int, int) target = (input[0], input[1]);

        int bessieToTarget = Math.Max(Math.Abs(bessie.Item1 - target.Item1), Math.Abs(bessie.Item2 - target.Item2));
        int daisyToTarget = Math.Abs(daisy.Item1 - target.Item1) + Math.Abs(daisy.Item2 - target.Item2);

        if (bessieToTarget < daisyToTarget)
        {
            Console.WriteLine("bessie");
        }
        else if (bessieToTarget > daisyToTarget)
        {
            Console.WriteLine("daisy");
        }
        else
        {
            Console.WriteLine("tie");
        }
    }
}