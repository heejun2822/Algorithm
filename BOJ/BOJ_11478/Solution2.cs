namespace Algorithm.BOJ.BOJ_11478
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_11478/input.txt",
        ];

        public static void Run(string[] args)
        {
            string S = Console.ReadLine()!;
            HashSet<string> subS = new();
            int cnt = 0;
            for (int len = 1; len <= S.Length; len++)
            {
                subS.Clear();
                for (int idx = 0; idx <= S.Length - len; idx++)
                {
                    subS.Add(S.Substring(idx, len));
                }
                cnt += subS.Count;
            }
            Console.WriteLine(cnt);
        }
    }
}
