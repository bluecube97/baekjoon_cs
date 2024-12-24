internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] nameArr = new string[n];
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            nameArr[i] = Console.ReadLine();
        }

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                int len = Math.Min(nameArr[i].Length, nameArr[j].Length);

                for (int k = 0; k < len; k++)
                {
                    string a = nameArr[i].Substring(nameArr[i].Length - k - 1);
                    string b = nameArr[j].Substring(0, k + 1);
                    string c = nameArr[i].Substring(0, k + 1);
                    string d = nameArr[j].Substring(nameArr[j].Length - k - 1);
                    if (nameArr[i].Substring(nameArr[i].Length - k - 1) == nameArr[j].Substring(0, k + 1)
                        || nameArr[i].Substring(0, k + 1) == nameArr[j].Substring(nameArr[j].Length - k - 1))
                    {
                        count++;
                        break;
                    }
                }
            }
        }

        Console.WriteLine(count);
    }
}