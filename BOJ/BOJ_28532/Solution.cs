namespace Algorithm.BOJ.BOJ_28532
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_28532/input1.txt",
            "BOJ/BOJ_28532/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            const int MAX = 100_000;
            const int MAX_K = 16;

            bool[] isPrime = new bool[MAX + 1];
            int[] primeFactorsCnt = new int[MAX + 1];

            Array.Fill(isPrime, true);

            for (int i = 2; i <= MAX; i++)
            {
                if (!isPrime[i]) continue;

                primeFactorsCnt[i] = 1;

                for (int j = i * 2; j <= MAX; j += i)
                {
                    isPrime[j] = false;

                    int tmp = j;
                    while (tmp % i == 0)
                    {
                        primeFactorsCnt[j]++;
                        tmp /= i;
                    }
                }
            }

            int[,] accSum = new int[MAX + 1, MAX_K + 1];

            for (int i = 2; i <= MAX; i++)
            {
                for (int j = 1; j <= MAX_K; j++)
                    accSum[i, j] = accSum[i - 1, j];
                if (primeFactorsCnt[i] <= MAX_K)
                    accSum[i, primeFactorsCnt[i]]++;
            }

            int q = ReadInt(sr);

            while (q-- > 0)
            {
                int l = ReadInt(sr), r = ReadInt(sr), k = ReadInt(sr);
                sw.WriteLine(accSum[r, k] - accSum[l - 1, k]);
            }

            sr.Close();
            sw.Close();
        }

        private static int ReadInt(StreamReader sr)
        {
            int c, val = 0, sign = 1;
            while (true)
            {
                c = sr.Read();
                if (c == ' ' || c == '\n' || c == -1) break;
                if (c == '\r') { sr.Read(); break; }
                if (c == '-') { sign = -1; continue; }
                val = val * 10 + c - '0';
            }
            return val * sign;
        }
    }
}
