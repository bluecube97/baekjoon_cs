internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<int> primeList = PrimeNumber(118);

        for (int i = 0; i < n; i++)
        {
            int atomic = int.Parse(Console.ReadLine());
            bool isPossible = false;

            for (int j = 0; j < 30; j++)
            {
                for (int k = j; k < 30; k++)
                {
                    if (primeList[j] + primeList[k] == atomic)
                    {
                        Console.WriteLine("Yes");
                        isPossible = true;
                        break;
                    }
                }

                if (isPossible)
                {
                    break;
                }
            }

            if (!isPossible)
            {
                Console.WriteLine("No");
            }
        }
    }

    static List<int> PrimeNumber(int limit)
    {
        bool[] isPrime = new bool[limit + 1];
        for (int i = 2; i <= limit; i++)
        {
            isPrime[i] = true;
        }

        for (int i = 2; i * i <= limit; i++)
        {
            if (isPrime[i])
            {
                for (int j = i * i; j <= limit; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }

        List<int> primes = new List<int>();
        for (int i = 2; i <= limit; i++)
        {
            if (isPrime[i])
            {
                primes.Add(i);
            }
        }

        return primes;
    }
}