namespace Algorithm.BOJ.BOJ_33710
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_33710/input1.txt",
            "BOJ/BOJ_33710/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]);
            int K = int.Parse(input[1]);
            string S = Console.ReadLine()!;

            List<int>[] indices = new List<int>[26];
            
            for (int i = 0; i < 26; i++)
                indices[i] = new();

            for (int i = N - 1; i >= 0; i--)
                if (S[i] != 'X')
                    indices[S[i] - 'A'].Add(i);

            int minLen = N;

            DFS(0, K, 0);

            Console.WriteLine(minLen);

            void DFS(int idx, int K, int len)
            {
                if (len >= minLen)
                    return;

                if (idx == N)
                {
                    minLen = Math.Min(minLen, len);
                    return;
                }

                if (K == 0)
                {
                    len += N - idx;
                    minLen = Math.Min(minLen, len);
                    return;
                }

                foreach (int nIdx in indices[S[idx] - 'A'])
                {
                    if (nIdx == idx) break;
                    DFS(nIdx + 1, K - 1, len);
                }

                DFS(idx + 1, K, len + 1);
            }
        }
    }
}
