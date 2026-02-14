namespace Algorithm.BOJ.BOJ_31433
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_31433/input.txt",
        ];

        public static void Run(string[] args)
        {
            string X = Console.ReadLine()!;

            int[] lengths = new int[3];
            char[] chars = { 'K', 'S', 'A' };

            foreach (char c in X)
            {
                char nc = c == 'K' ? 'S' : c == 'S' ? 'A' : 'K';
                for (int i = 0; i < 3; i++)
                {
                    if (chars[i] == c)
                    {
                        lengths[i]++;
                        chars[i] = nc;
                    }
                }
            }

            int minCnt = (X.Length - lengths[0]) * 2;
            minCnt = Math.Min(minCnt, X.Length - lengths[1] + 2 + Math.Abs(X.Length - (lengths[1] - 2)));
            minCnt = Math.Min(minCnt, X.Length - lengths[1] + 1 + Math.Abs(X.Length - (lengths[1] + 1)));
            minCnt = Math.Min(minCnt, X.Length - lengths[2] + 1 + Math.Abs(X.Length - (lengths[2] - 1)));
            minCnt = Math.Min(minCnt, X.Length - lengths[2] + 2 + Math.Abs(X.Length - (lengths[2] + 2)));

            Console.WriteLine(minCnt);
        }
    }
}
