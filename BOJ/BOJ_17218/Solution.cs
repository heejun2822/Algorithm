namespace Algorithm.BOJ.BOJ_17218
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_17218/input1.txt",
            "BOJ/BOJ_17218/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string str1 = Console.ReadLine()!;
            string str2 = Console.ReadLine()!;

            int[,] dp = new int[str1.Length + 1, str2.Length + 1];
            (int, int)[,] trace = new (int, int)[str1.Length + 1, str2.Length + 1];

            for (int i = 1; i <= str1.Length; i++)
            {
                for (int j = 1; j <= str2.Length; j++)
                {
                    if (str1[i - 1] == str2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                        trace[i, j] = (i - 1, j - 1);
                    }
                    else if (dp[i - 1, j] > dp[i, j - 1])
                    {
                        dp[i, j] = dp[i - 1, j];
                        trace[i, j] = (i - 1, j);
                    }
                    else
                    {
                        dp[i, j] = dp[i, j - 1];
                        trace[i, j] = (i, j - 1);
                    }
                }
            }

            Stack<char> stack = new(dp[str1.Length, str2.Length]);
            int idx1 = str1.Length, idx2 = str2.Length;

            while (idx1 > 0 && idx2 > 0)
            {
                if (str1[idx1 - 1] == str2[idx2 - 1])
                    stack.Push(str1[idx1 - 1]);
                (idx1, idx2) = trace[idx1, idx2];
            }

            string password = "";

            while (stack.Count > 0)
                password += stack.Pop();

            Console.WriteLine(password);
        }
    }
}
