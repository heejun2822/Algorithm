namespace Algorithm.BOJ.BOJ_11478
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_11478/input.txt",
        ];

        public static void Run(string[] args)
        {
            string S = Console.ReadLine()!;
            HashSet<string> subS = new();
            for (int idx = 0; idx < S.Length; idx++)
            {
                for (int len = 1; len <= S.Length - idx; len++)
                {
                    subS.Add(S.Substring(idx, len));
                }
            }
            Console.WriteLine(subS.Count);
        }
    }
}
