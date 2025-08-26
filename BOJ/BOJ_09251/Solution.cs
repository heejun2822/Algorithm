namespace Algorithm.BOJ.BOJ_09251
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_09251/input.txt",
        ];

        public static void Run(string[] args)
        {
            string str1 = Console.ReadLine()!;
            string str2 = Console.ReadLine()!;

            // LCS (Longest Common Subsequence)
            int[,] LCS = new int[str1.Length + 1, str2.Length + 1];
            for (int i = 0; i < str1.Length; i++)
            for (int j = 0; j < str2.Length; j++)
                LCS[i + 1, j + 1] = str1[i] == str2[j]
                    ? LCS[i, j] + 1
                    : Math.Max(LCS[i, j + 1], LCS[i + 1, j]);

            Console.WriteLine(LCS[str1.Length, str2.Length]);
        }
    }
}
