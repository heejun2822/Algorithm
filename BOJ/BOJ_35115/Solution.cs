namespace Algorithm.BOJ.BOJ_35115
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_35115/input1.txt",
            "BOJ/BOJ_35115/input2.txt",
            "BOJ/BOJ_35115/input3.txt",
            "BOJ/BOJ_35115/input4.txt",
            "BOJ/BOJ_35115/input5.txt",
            "BOJ/BOJ_35115/input6.txt",
        ];

        public static void Run(string[] args)
        {
            string S = Console.ReadLine()!;
            string T = Console.ReadLine()!;

            int lenS = S.Length, lenT = T.Length;
            S = " " + S;
            T = " " + T;

            bool[,] dp = new bool[lenT + 1, lenS + 1];
            dp[0, 0] = true;

            for (int i = 1; i <= lenT; i++)
            {
                bool isPossible = false;

                for (int j = 1; j <= lenS; j++)
                {
                    dp[i, j] = dp[i - 1, j - 1] && T[i] == S[j];
                    isPossible |= dp[i, j];
                }

                int num = 0;
                int place = 1;
                int idx = i;

                while (idx > 0 && char.IsDigit(T[idx]))
                {
                    if (T[idx] > '0')
                    {
                        num = (T[idx] - '0') * place + num;

                        if (num > lenS) break;

                        for (int j = lenS; j > 0; j--)
                        {
                            if (j - num < 0) break;

                            dp[i, j] |= dp[idx - 1, j - num];
                            isPossible |= dp[i, j];
                        }
                    }

                    place *= 10;
                    idx--;
                }

                if (!isPossible) break;
            }

            Console.WriteLine(dp[lenT, lenS] ? "Yes" : "No");
        }
    }
}
