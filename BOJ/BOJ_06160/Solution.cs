namespace Algorithm.BOJ.BOJ_06160
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_06160/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nk = Console.ReadLine()!.Split();
            int N = int.Parse(nk[0]);
            int K = int.Parse(nk[1]);

            (int i, int A, int B)[] cows = new (int, int, int)[N];
            for (int i = 0; i < N; i++)
            {
                string[] ab = Console.ReadLine()!.Split();
                cows[i] = (i + 1, int.Parse(ab[0]), int.Parse(ab[1]));
            }

            Array.Sort(cows, (a, b) => b.A.CompareTo(a.A));

            int maxVotes = 0;
            int winner = 0;
            for (int i = 0; i < K; i++)
            {
                if (cows[i].B > maxVotes)
                {
                    maxVotes = cows[i].B;
                    winner = cows[i].i;
                }
            }

            Console.WriteLine(winner);
        }
    }
}
