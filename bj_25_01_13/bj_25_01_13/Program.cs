internal class Program
{
    static void Main(string[] args)
    {
        string NLCS = "northlondo";
        string BHA = "branksomeh";
        string KIS = "koreainter";
        string SJA = "stjohnsbur";

        string input = Console.ReadLine();

        for (int N = 0; N < 26; N++)
        {
            string decrypted = Decrypt(input, N);

            if (decrypted == NLCS)
            {
                Console.WriteLine("NLCS");
                return;
            }
            if (decrypted == BHA)
            {
                Console.WriteLine("BHA");
                return;
            }
            if (decrypted == KIS)
            {
                Console.WriteLine("KIS");
                return;
            }
            if (decrypted == SJA)
            {
                Console.WriteLine("SJA");
                return;
            }
        }
    }

    static string Decrypt(string encrypted, int shift)
    {
        char[] decrypted = new char[10];

        for (int i = 0; i < 10; i++)
        {
            char c = encrypted[i];

            c = (char)((c - 'a' - shift + 26) % 26 + 'a');

            decrypted[i] = c;
        }

        return new string(decrypted);
    }
}