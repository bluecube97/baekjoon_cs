internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            FindSeminarClass(Console.ReadLine());
        }
    }

    static void FindSeminarClass(string name)
    {
        switch (name)
        {
            case "Algorithm":
                Console.WriteLine(204);
                break;
            case "DataAnalysis":
                Console.WriteLine(207);
                break;
            case "ArtificialIntelligence":
                Console.WriteLine(302);
                break;
            case "CyberSecurity":
                Console.WriteLine("B101");
                break;
            case "Network":
                Console.WriteLine(303);
                break;
            case "Startup":
                Console.WriteLine(501);
                break;
            case "TestStrategy":
                Console.WriteLine(105);
                break;
        }
    }
}