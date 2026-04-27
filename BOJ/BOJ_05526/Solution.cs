namespace Algorithm.BOJ.BOJ_05526
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_05526/input1.txt",
            "BOJ/BOJ_05526/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]), M = int.Parse(input[1]);

            int[] P = new int[N + 1];

            for (int i = 1; i <= N; i++)
                P[i] = int.Parse(Console.ReadLine()!);

            int[] sums = new int[(N + 2) * (N + 1) / 2];
            int idx = 0;

            for (int i = 0; i <= N; i++)
                for (int j = i; j <= N; j++)
                    sums[idx++] = P[i] + P[j];

            Array.Sort(sums);

            int l = 0, r = sums.Length - 1;
            int maxScore = 0;

            while (l <= r)
            {
                int score = sums[l] + sums[r];

                if (score <= M)
                {
                    maxScore = Math.Max(maxScore, score);
                    l++;
                }
                else
                {
                    r--;
                }
            }

            Console.WriteLine(maxScore);
        }
    }
}
