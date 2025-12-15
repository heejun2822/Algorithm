namespace Algorithm.BOJ.BOJ_25381
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_25381/input1.txt",
            "BOJ/BOJ_25381/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string S = Console.ReadLine()!;

            int[] indicesB = new int[S.Length];
            int s = 0, e = -1;

            int cnt = 0;

            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == 'B')
                {
                    indicesB[++e] = i;
                }
                else if (S[i] == 'C' && e - s + 1 > 0)
                {
                    s++;
                    cnt++;
                }
            }

            for (int i = S.Length - 1; i >= 0; i--)
            {
                if (e - s + 1 == 0) break;

                if (S[i] == 'A' && indicesB[e] > i)
                {
                    e--;
                    cnt++;
                }
            }

            Console.WriteLine(cnt);
        }
    }
}
