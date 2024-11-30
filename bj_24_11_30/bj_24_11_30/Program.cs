internal class Program
{
    static void Main(string[] args)
    {
        int s = int.Parse(Console.ReadLine());
        string str = Console.ReadLine();

        if (s == 2)
        {
            Console.WriteLine(0);
        }
        else if (str[s - 2] == 'k' || str[s - 2] == 'o' || str[s - 2] == 'i' || str[s - 2] == 'O'
            || str[s - 2] == 'j' || str[s - 2] == 'p' || str[s - 2] == 'u' || str[s - 2] == 'P'
            || str[s - 2] == 'h' || str[s - 2] == 'y' || str[s - 2] == 'b' || str[s - 2] == 'm'
            || str[s - 2] == 'l' || (str[s - 3] == 'h' && str[s - 2] == 'k') || (str[s - 3] == 'h' && str[s - 2] == 'o')
            || (str[s - 3] == 'h' && str[s - 2] == 'l') || (str[s - 3] == 'n' && str[s - 2] == 'j')
            || (str[s - 3] == 'n' && str[s - 2] == 'p') || (str[s - 3] == 'n' && str[s - 2] == 'l')
            || (str[s - 3] == 'm' && str[s - 2] == 'l'))
        {
            Console.WriteLine(1);
        }
        else if (str[s - 1] == 'r' || str[s - 1] == 'R' || str[s - 1] == 's' || str[s - 1] == 'e'
                 || str[s - 1] == 'f' || str[s - 1] == 'a' || str[s - 1] == 'q' || str[s - 1] == 't'
                 || str[s - 1] == 'T' || str[s - 1] == 'd' || str[s - 1] == 'w' || str[s - 1] == 'c'
                 || str[s - 1] == 'z' || str[s - 1] == 'x' || str[s - 1] == 'v' || str[s - 1] == 'g'
                 || (str[s - 2] == 'r' && str[s - 1] == 't') || (str[s - 2] == 's' && str[s - 1] == 'w')
                 || (str[s - 2] == 's' && str[s - 1] == 'g') || (str[s - 2] == 'f' && str[s - 1] == 'r')
                 || (str[s - 2] == 'f' && str[s - 1] == 'a') || (str[s - 2] == 'f' && str[s - 1] == 'q')
                 || (str[s - 2] == 'f' && str[s - 1] == 't') || (str[s - 2] == 'f' && str[s - 1] == 'x')
                 || (str[s - 2] == 'f' && str[s - 1] == 'v') || (str[s - 2] == 'f' && str[s - 1] == 'g')
                 || (str[s - 2] == 'q' && str[s - 1] == 't'))
        {
            Console.WriteLine(1);
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}