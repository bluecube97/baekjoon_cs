internal class Program
{
    static void Main(string[] args)
    {
        var inputQuestion = new StreamReader(Console.OpenStandardInput());
        while (inputQuestion.Peek() != -1)
        {
            string input = inputQuestion.ReadLine();
            Console.WriteLine(input);
        }
    }
}