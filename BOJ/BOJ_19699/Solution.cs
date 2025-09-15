namespace Algorithm.BOJ.BOJ_19699
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_19699/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);
            int[] H = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            Array.Sort(H, (a, b) => b - a);

            int size = 0;
            for (int i = 0; i < M; i++)
                size += H[i];

            bool[] isPrime = new bool[size + 1];
            Array.Fill(isPrime, true);

            int lim = (int)Math.Sqrt(size);

            for (int i = 2; i <= lim; i++)
                if (isPrime[i])
                    for (int j = i * 2; j <= size; j += i)
                        isPrime[j] = false;

            SortedSet<int> primes = new();

            Combination(0, 0, 0);

            Console.WriteLine(primes.Count > 0 ? string.Join(' ', primes) : "-1");

            void Combination(int idx, int cnt, int sum)
            {
                if (cnt == M)
                {
                    if (isPrime[sum])
                        primes.Add(sum);
                    return;
                }

                if (idx == N) return;

                Combination(idx + 1, cnt + 1, sum + H[idx]);
                Combination(idx + 1, cnt, sum);
            }
        }
    }
}
