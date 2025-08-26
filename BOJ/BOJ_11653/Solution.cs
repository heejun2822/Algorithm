namespace Algorithm.BOJ.BOJ_11653
{
    using System.Text;

    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_11653/input1.txt",
            "BOJ/BOJ_11653/input2.txt",
            "BOJ/BOJ_11653/input3.txt",
            "BOJ/BOJ_11653/input4.txt",
            "BOJ/BOJ_11653/input5.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            if (N == 1) return;
            List<int> primes = GetPrimes(N);
            StringBuilder answer = new();
            foreach (int prime in primes)
            {
                while (N % prime == 0)
                {
                    answer.AppendLine(prime.ToString());
                    N /= prime;
                }
            }
            Console.WriteLine(answer);
        }

        private static List<int> GetPrimes(int N)
        {
            bool[] IsPrime = Enumerable.Repeat(true, N + 1).ToArray();
            IsPrime[0] = IsPrime[1] = false;
            for (int i = 2; i <= Math.Sqrt(N); i++)
            {
                if (!IsPrime[i]) continue;
                for (int j = 2 * i; j < IsPrime.Length; j += i) IsPrime[j] = false;
            }
            List<int> primes = new();
            for (int i = 0; i < IsPrime.Length; i++)
            {
                if (IsPrime[i]) primes.Add(i);
            }
            return primes;
        }
    }
}
