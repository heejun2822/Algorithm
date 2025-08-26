namespace Algorithm.BOJ.BOJ_25501
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_25501/input.txt",
        ];

        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine()!);
            for (int _ = 0; _ < T; _++)
            {
                string S = Console.ReadLine()!;
                (int res, int cnt) = IsPalindrome(S);
                Console.WriteLine($"{res} {cnt}");
            }
        }

        private static int Recursion(string s, int l, int r, ref int cnt)
        {
            cnt++;
            if (l >= r) return 1;
            if (s[l] != s[r]) return 0;
            return Recursion(s, l + 1, r - 1, ref cnt);
        }

        private static (int res, int cnt) IsPalindrome(string s)
        {
            int cnt = 0;
            int res = Recursion(s, 0, s.Length - 1, ref cnt);
            return (res, cnt);
        }
    }
}
