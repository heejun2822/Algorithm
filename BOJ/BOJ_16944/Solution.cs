namespace Algorithm.BOJ.BOJ_16944
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_16944/input1.txt",
            "BOJ/BOJ_16944/input2.txt",
            "BOJ/BOJ_16944/input3.txt",
            "BOJ/BOJ_16944/input4.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            string S = Console.ReadLine()!;

            bool hasDigit = false;
            bool hasLowerCase = false;
            bool hasUpperCase = false;
            bool hasSpecialChar = false;

            for (int i = 0; i < N; i++)
            {
                if (S[i] >= '0' && S[i] <= '9') hasDigit = true;
                else if (S[i] >= 'a' && S[i] <= 'z') hasLowerCase = true;
                else if (S[i] >= 'A' && S[i] <= 'Z') hasUpperCase = true;
                else hasSpecialChar = true;
            }

            int cnt = 0;
            if (!hasDigit) cnt++;
            if (!hasLowerCase) cnt++;
            if (!hasUpperCase) cnt++;
            if (!hasSpecialChar) cnt++;
            cnt += Math.Max(6 - (N + cnt), 0);

            Console.WriteLine(cnt);
        }
    }
}
