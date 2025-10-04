namespace Algorithm.BOJ.BOJ_09753
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_09753/input.txt",
        ];

        public static void Run(string[] args)
        {
            const int MAX = 50000;
            bool[] isPrime = new bool[MAX + 1];
            Array.Fill(isPrime, true);
            isPrime[0] = isPrime[1] = false;
            List<int> primes = new();

            for (int i = 2; i <= MAX; i++)
            {
                if (!isPrime[i]) continue;
                primes.Add(i);
                for (int j = i * 2; j <= MAX; j += i)
                    isPrime[j] = false;
            }

            int T = int.Parse(Console.ReadLine()!);

            while (T-- > 0)
            {
                int K = int.Parse(Console.ReadLine()!);

                int num = K;
                bool found = false;

                while (!found)
                {
                    int idx = 0;
                    int lim = MAX;

                    while (primes[idx] <= lim)
                    {
                        if (num % primes[idx] == 0)
                        {
                            int q = num / primes[idx];
                            found = isPrime[q] && q != primes[idx];
                            break;
                        }
                        lim = num / primes[idx++];
                    }

                    if (!found)
                        num++;
                }

                Console.WriteLine(num);
            }
        }
    }
}
