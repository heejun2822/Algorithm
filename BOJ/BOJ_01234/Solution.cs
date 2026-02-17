namespace Algorithm.BOJ.BOJ_01234
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01234/input1.txt",
            "BOJ/BOJ_01234/input2.txt",
            "BOJ/BOJ_01234/input3.txt",
            "BOJ/BOJ_01234/input4.txt",
            "BOJ/BOJ_01234/input5.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]);
            int max = N * (N + 1) / 2;
            int R = Math.Min(int.Parse(input[1]), max);
            int G = Math.Min(int.Parse(input[2]), max);
            int B = Math.Min(int.Parse(input[3]), max);

            int[] factorial = new int[N + 1];

            factorial[0] = 1;
            for (int i = 1; i <= N; i++)
                factorial[i] = factorial[i - 1] * i;

            long[,,] dp = new long[N + 1, R + 1, G + 1];

            for (int f = 0; f <= N; f++)
                for (int r = 0; r <= R; r++)
                    for (int g = 0; g <= G; g++)
                        dp[f, r, g] = -1;

            Console.WriteLine(DFS(1, R, G, B));

            long DFS(int f, int r, int g, int b)
            {
                if (f > N)
                    return 1;

                if (dp[f, r, g] == -1)
                {
                    long cnt = 0;

                    if (r >= f)
                        cnt += CaseCount(f, 0, 0) * DFS(f + 1, r - f, g, b);
                    if (g >= f)
                        cnt += CaseCount(0, f, 0) * DFS(f + 1, r, g - f, b);
                    if (b >= f)
                        cnt += CaseCount(0, 0, f) * DFS(f + 1, r, g, b - f);

                    if (f % 2 == 0)
                    {
                        int hf = f / 2;
                        if (r >= hf && g >= hf)
                            cnt += CaseCount(hf, hf, 0) * DFS(f + 1, r - hf, g - hf, b);
                        if (r >= hf && b >= hf)
                            cnt += CaseCount(hf, 0, hf) * DFS(f + 1, r - hf, g, b - hf);
                        if (g >= hf && b >= hf)
                            cnt += CaseCount(0, hf, hf) * DFS(f + 1, r, g - hf, b - hf);
                    }

                    if (f % 3 == 0)
                    {
                        int tf = f / 3;
                        if (r >= tf && g >= tf && b >= tf)
                            cnt += CaseCount(tf, tf, tf) * DFS(f + 1, r - tf, g - tf, b - tf);
                    }

                    dp[f, r, g] = cnt;
                }

                return dp[f, r, g];
            }

            int CaseCount(int a, int b, int c)
            {
                return factorial[a + b + c] / factorial[a] / factorial[b] / factorial[c];
            }
        }
    }
}
