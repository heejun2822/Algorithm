namespace Algorithm.BOJ.BOJ_12919
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_12919/input1.txt",
            "BOJ/BOJ_12919/input2.txt",
            "BOJ/BOJ_12919/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string S = Console.ReadLine()!;
            string T = Console.ReadLine()!;

            Console.WriteLine(DFS(T.Length, 0, T.Length - 1, false) ? 1 : 0);

            bool DFS(int len, int start, int end, bool reversed)
            {
                if (len == S.Length)
                {
                    if (reversed)
                    {
                        for (int i = 0; i < S.Length; i++)
                            if (S[i] != T[end - i])
                                return false;
                        return true;
                    }
                    else
                    {
                        for (int i = 0; i < S.Length; i++)
                            if (S[i] != T[start + i])
                                return false;
                        return true;
                    }
                }

                if (reversed)
                {
                    if (T[start] == 'A' && DFS(len - 1, start + 1, end, reversed)) return true;
                    if (T[end] == 'B' && DFS(len - 1, start, end - 1, !reversed)) return true;
                }
                else
                {
                    if (T[end] == 'A' && DFS(len - 1, start, end - 1, reversed)) return true;
                    if (T[start] == 'B' && DFS(len - 1, start + 1, end, !reversed)) return true;
                }
                return false;
            }
        }
    }
}
