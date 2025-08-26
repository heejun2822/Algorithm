namespace Algorithm.BOJ.BOJ_01010
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01010/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());

            int T = int.Parse(sr.ReadLine()!);
            for (int _ = 0; _ < T; _++)
            {
                string[] nm = sr.ReadLine()!.Split();
                int N = int.Parse(nm[0]);
                int M = int.Parse(nm[1]);

                int k1 = Math.Max(N, M - N);
                int k2 = Math.Min(N, M - N);
                int res = 1;
                int div = 2;
                for (int i = M; i > k1; i--)
                {
                    res *= i;
                    while (div <= k2)
                    {
                        if (res % div != 0) break;
                        res /= div++;
                    }
                }
                sw.WriteLine(res);
            }

            sr.Close();
            sw.Close();
        }
    }
}
