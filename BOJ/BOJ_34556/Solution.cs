namespace Algorithm.BOJ.BOJ_34556
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_34556/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            string[] males = new string[N];
            string[] females = new string[N];

            for (int i = 0; i < N; i++)
                males[i] = Console.ReadLine()!;
            for (int i = 0; i < N; i++)
                females[i] = Console.ReadLine()!;

            bool[] visited = new bool[N];
            int maxScore = 0;

            Permutate(0, 0);

            Console.WriteLine(maxScore);

            void Permutate(int idx, int totalScore)
            {
                if (idx == N)
                {
                    maxScore = Math.Max(maxScore, totalScore);
                    return;
                }

                for (int i = 0; i < N; i++)
                {
                    if (visited[i]) continue;

                    visited[i] = true;
                    Permutate(idx + 1, totalScore + GetScore(males[idx], females[i]));
                    visited[i] = false;
                }
            }

            int GetScore(string a, string b)
            {
                int score = 0;

                for (int i = 0; i < 4; i++)
                    if (a[i] != b[i])
                        score++;

                return score;
            }
        }
    }
}
