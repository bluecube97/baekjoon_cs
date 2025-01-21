internal class Program
{
    static void Main(string[] args)
    {
        string[] resistance = new string[3];
        resistance[0] = Console.ReadLine();
        resistance[1] = Console.ReadLine();
        resistance[2] = Console.ReadLine();

        for (int i = 0; i < 2; i++)
        {
            resistance[i] = resistance[i] switch
            {
                "black" => "0",
                "brown" => "1",
                "red" => "2",
                "orange" => "3",
                "yellow" => "4",
                "green" => "5",
                "blue" => "6",
                "violet" => "7",
                "grey" => "8",
                "white" => "9",
                _ => resistance[i]
            };
        }
        resistance[2] = resistance[2] switch
        {
            "black" => "1",
            "brown" => "10",
            "red" => "100",
            "orange" => "1000",
            "yellow" => "10000",
            "green" => "100000",
            "blue" => "1000000",
            "violet" => "10000000",
            "grey" => "100000000",
            "white" => "1000000000",
            _ => resistance[2]
        };

        string result = resistance[0] + resistance[1];
        result = (long.Parse(result) * long.Parse(resistance[2])).ToString();
        Console.WriteLine(result);
    }
}