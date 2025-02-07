internal class Program
{
    static void Main(string[] args)
    {
        int[] ggung = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] seok = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int ggungScore = ggung[0] + ggung[1] + ggung[2] + ggung[3];
        int seokScore = seok[0] + seok[1] + seok[2] + seok[3];

        if (ggungScore > seokScore)
        {
            Console.WriteLine("Gunnar");
        }
        else if (ggungScore < seokScore)
        {
            Console.WriteLine("Emma");
        }
        else
        {
            Console.WriteLine("Tie");
        }
    }
}