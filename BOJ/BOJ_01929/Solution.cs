namespace Algorithm.BOJ.BOJ_01929
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01929/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());
            string[] mn = sr.ReadLine()!.Split();
            int M = int.Parse(mn[0]);
            int N = int.Parse(mn[1]);
            // 에라토스테네스의 체
            bool[] isPrime = Enumerable.Repeat(true, N + 1).ToArray();
            isPrime[0] = isPrime[1] = false;
            int limit = (int)Math.Sqrt(N);
            for (int i = 2; i <= limit; i++)
            {
                if (!isPrime[i]) continue;
                for (int j = i * 2; j <= N; j += i) isPrime[j] = false;
            }
            for (int i = M; i <= N; i++)
            {
                if (isPrime[i]) sw.WriteLine(i);
            }
            sr.Close();
            sw.Close();
        }
    }
}
