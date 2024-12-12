namespace Algorithm.BOJ.BOJ_14889
{
    public class Solution2
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_14889/input1.txt",
            "BOJ/BOJ_14889/input2.txt",
            "BOJ/BOJ_14889/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[,] S = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine()!.Split();
                for (int j = 0; j < N; j++) S[i, j] = int.Parse(input[j]);
            }

            bool[] team = new bool[N];
            team[0] = true;
            int minDiff = int.MaxValue;
            MakeTeam(N, S, team, 1, 1, ref minDiff);

            Console.WriteLine(minDiff);
        }

        private static void MakeTeam(int N, int[,] S, bool[] team, int cnt, int idx, ref int minDiff)
        {
            if (cnt == N / 2)
            {
                int diff = 0;
                for (int i = 0; i < N - 1; i++)
                for (int j = i + 1; j < N; j++)
                {
                    if (team[i] && team[j]) diff += S[i, j] + S[j, i];
                    else if (!team[i] && !team[j]) diff -= S[i, j] + S[j, i];
                }
                minDiff = Math.Min(minDiff, Math.Abs(diff));
                return;
            }

            if (idx == N) return;

            team[idx] = true;
            MakeTeam(N, S, team, cnt + 1, idx + 1, ref minDiff);
            team[idx] = false;
            MakeTeam(N, S, team, cnt, idx + 1, ref minDiff);
        }
    }
}
