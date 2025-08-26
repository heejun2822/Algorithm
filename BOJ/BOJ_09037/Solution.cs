namespace Algorithm.BOJ.BOJ_09037
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_09037/input.txt",
        ];

        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine()!);

            for (int _ = 0; _ < T; _++)
            {
                int N = int.Parse(Console.ReadLine()!);
                int[] C = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

                for (int i = 0; i < N; i++)
                    if (C[i] % 2 == 1) C[i]++;

                int cnt = 0;

                while (!IsAllSame(C, N))
                {
                    int prevC = C[N - 1];

                    for (int i = 0; i < N; i++)
                    {
                        (C[i], prevC) = ((prevC + C[i]) / 2, C[i]);
                        if (C[i] % 2 == 1) C[i]++;
                    }

                    cnt++;
                }

                Console.WriteLine(cnt);
            }

            bool IsAllSame(int[] C, int N)
            {
                for (int i = 1; i < N; i++)
                    if (C[i - 1] != C[i])
                        return false;
                return true;
            }
        }
    }
}
