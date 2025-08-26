namespace Algorithm.BOJ.BOJ_02495
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02495/input.txt",
        ];

        public static void Run(string[] args)
        {
            for (int _ = 0; _ < 3; _++)
            {
                string num = Console.ReadLine()!;
                int maxCnt = 1;
                int cnt = 1;
                char prevDigit = num[0];
                for (int i = 1; i < 8; i++)
                {
                    if (num[i] == prevDigit)
                    {
                        maxCnt = Math.Max(maxCnt, ++cnt);
                    }
                    else
                    {
                        cnt = 1;
                        prevDigit = num[i];
                    }
                }
                Console.WriteLine(maxCnt);
            }
        }
    }
}
