namespace Algorithm.BOJ.BOJ_03099
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_03099/input1.txt",
            "BOJ/BOJ_03099/input2.txt",
            "BOJ/BOJ_03099/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string word = Console.ReadLine()!;

            int[] dp = new int[26];
            Array.Fill(dp, -1);
            dp[word[0] - 'A'] = 1;

            for (int i = 1; i < word.Length; i++)
            {
                int idx = word[i] - 'A';

                int min = 10_000;

                for (int j = 0; j < 26; j++)
                {
                    if (j == idx) continue;
                    if (dp[j] == -1) continue;

                    min = Math.Min(min, dp[j]++);
                }

                if (dp[idx] == -1)
                    dp[idx] = min + 1;
                else
                    dp[idx] = Math.Min(dp[idx], min + 1);
            }

            int cnt = 10_000;
            for (int i = 0; i < 26; i++)
                if (dp[i] != -1)
                    cnt = Math.Min(cnt, dp[i]);
            cnt += word.Length;

            Console.WriteLine(cnt);
        }
    }
}
