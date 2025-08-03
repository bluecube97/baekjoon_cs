internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        char[] dna = isr.ReadLine().ToCharArray();

        for (int i = n - 1; i > 0; i--)
        {
            dna[i - 1] = CalcDna(dna[i - 1], dna[i]);
        }

        Console.WriteLine(dna[0]);
    }

    private static char CalcDna(char dna1, char dna2)
    {
        if ((dna1 == 'A' && dna2 == 'A') || (dna1 == 'A' && dna2 == 'C') || (dna1 == 'G' && dna2 == 'T') ||
            (dna1 == 'C' && dna2 == 'A') || (dna1 == 'T' && dna2 == 'G'))
        {
            return 'A';
        }
        else if ((dna1 == 'A' && dna2 == 'G') || (dna1 == 'G' && dna2 == 'A') || (dna1 == 'C' && dna2 == 'C'))
        {
            return 'C';
        }
        else if ((dna1 == 'A' && dna2 == 'T') || (dna1 == 'G' && dna2 == 'G') || (dna1 == 'C' && dna2 == 'T') ||
                 (dna1 == 'T' && dna2 == 'A') || (dna1 == 'T' && dna2 == 'C'))
        {
            return 'G';
        }
        else if ((dna1 == 'G' && dna2 == 'C') || (dna1 == 'C' && dna2 == 'G') || (dna1 == 'T' && dna2 == 'T'))
        {
            return 'T';
        }
        else
        {
            return 'X';
        }
    }
}